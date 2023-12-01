using System;
using System.Configuration;
using System.Data.SqlClient;

namespace AppalachianTrailProject
{
    public class Student
    {
        public String stuId { get; set; }
        public String period { get; set; }
        public string password { get; set; }
        public int steps { get; set; }
        public double miles
        {
            get
            {
                return Math.Round((double)steps / 2000, 2);
            }
        }
        public string firName { get; set; }
        public string lastName { get; set; }
        //public Student(String id, String pd, String Password)
        //{
        //    stuId = id;
        //    period = pd;
        //    password = Password.GetHashCode().ToString();
        //    steps = 0;
        //    miles = 0;
        //}
        public void addMiles(int num)
        {
            steps = steps + num;
        }
        //public static double calculate(Dictionary<String, Student> dict, String pd)
        //{
        //    double total = 0;
        //    //foreach (Student s in dict.Values)
        //    //{
        //    //    if (s.stuId == "007" || s.period == pd)
        //    //    {
        //    //        total += s.miles;
        //    //    }
        //    //}
        //    return total;
        //}

        internal static string[] GetClassTotalMiles(params string[] periods)
        {
            string[] returnVal = new string[periods.Length];
            var connectionString = ConfigurationManager.ConnectionStrings["rdSqlDatabase"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                for (int i = 0; i < periods.Length; i++)
                {
                    //string whereclause = periods[i] == "" ? "''" : periods[i];
                    string statement = $"select sum(TotalSteps) from students where period =@period";
                    using (var command = new SqlCommand(statement, connection))
                    {
                        command.Parameters.AddWithValue("@period", periods[i]);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows && reader.Read())
                            {
                                if (reader.IsDBNull(0))
                                {
                                    returnVal[i] = "0";
                                }
                                else
                                {
                                    var totalMiles = Math.Round((double)reader.GetInt32(0) / 2000, 2);
                                    returnVal[i] = totalMiles.ToString();
                                }
                            }
                            else
                            {
                                returnVal[i] = "0";
                            }

                        }
                    }
                }
            }
            return returnVal;
        }

        internal static string GetLogSteps(DateTime date)
        {
            System.Text.StringBuilder content = null;

            var connectionString = ConfigurationManager.ConnectionStrings["rdSqlDatabase"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string statement = $"select s.StuID, s.LastName, s.FirstName, s.Period, l.Steps, s.TotalSteps from students s join StepsLog l on s.StuID = l.StuID where l.LogDate = @date";
                using (var command = new SqlCommand(statement, connection))
                {
                    command.Parameters.AddWithValue("@date", date);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (content == null)
                            {
                                content = new System.Text.StringBuilder();
                                content.Append("Student ID, Last Name, First Name, Period, Steps, Total Miles\r\n");
                            }

                            while (reader.Read())
                            {
                                content.Append($"{reader.GetString(0)}, {reader.GetString(1)}, {reader.GetString(2)}, {reader.GetString(3)},{reader.GetInt32(4)}, {Math.Round((double)reader.GetInt32(5) / 2000, 2)}\r\n");
                            }
                        }

                        return content?.ToString();
                    }
                }
            }
        }

        //public static void saveDict(HttpApplicationState app, Dictionary<string, Student> data)
        //{
        //    var filepath = app["Filename"] as string;

        //    using (var wr = new StreamWriter(filepath))
        //    {
        //        var jsonS = JsonConvert.SerializeObject(data);
        //        wr.Write(jsonS);
        //    }

        //}

        internal static Student GetStudent(string stuID)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["rdSqlDatabase"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var statement = "select StuID, LastName, FirstName, Period, Pwd, TotalSteps from students where StuID = @StuID";
                using (var command = new SqlCommand(statement, connection))
                {
                    command.Parameters.AddWithValue("@StuID", stuID);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows && reader.Read())
                        {
                            //var data = reader.
                            var stu = new Student();
                            stu.stuId = reader.GetString(0);
                            stu.lastName = reader.GetString(1);
                            stu.firName = reader.GetString(2);
                            if (!reader.IsDBNull(3))
                                stu.period = reader.GetString(3);
                            stu.password = reader.GetString(4);
                            if (!reader.IsDBNull(5))
                                stu.steps = reader.GetInt32(5);
                            return stu;
                        }
                    }
                }
            }
            return null;
        }

        internal void UpdateSteps(int dailysteps)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["rdSqlDatabase"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var statement = $"update students Set TotalSteps = @steps where stuID = @StuID";
                using (var command = new SqlCommand(statement, connection))
                {
                    command.Parameters.AddWithValue("@steps", steps);
                    command.Parameters.AddWithValue("@StuID", stuId);
                    command.ExecuteNonQuery();
                }

                var logDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));

                var statement2 = $"insert into StepsLog (StuID, Steps, LogDate) values (@StuID, @dailysteps, @logDate)";
                using (var command2 = new SqlCommand(statement2, connection))
                {
                    command2.Parameters.AddWithValue("@logDate", logDate);
                    command2.Parameters.AddWithValue("@dailysteps", dailysteps);
                    command2.Parameters.AddWithValue("@StuID", stuId);
                    command2.ExecuteNonQuery();
                }
            }
        }

        internal void Update()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["rdSqlDatabase"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var statement = $"update students Set LastName = @lastName, FirstName =@firName, Period =@period, Pwd =@password where stuID = @StuID";
                using (var command = new SqlCommand(statement, connection))
                {
                    command.Parameters.AddWithValue("@StuID", stuId);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@firName", firName);
                    command.Parameters.AddWithValue("@period", period);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
            }
        }

        internal void SaveNew()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["rdSqlDatabase"].ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var statement = $"insert into students (StuID, LastName, FirstName, Period, Pwd) values (@StuID, @lastName, @firName, @period,@password)";
                using (var command = new SqlCommand(statement, connection))
                {
                    command.Parameters.AddWithValue("@StuID", stuId);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@firName", firName);
                    command.Parameters.AddWithValue("@period", period);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}