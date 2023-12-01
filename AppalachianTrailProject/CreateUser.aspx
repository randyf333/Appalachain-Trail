<%@ Page Title="TJHSST Appalachian Trail Challenge" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="AppalachianTrailProject.CreateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    &nbsp;<br />
    <span style="font-size: xx-large"><strong>Create User</strong></span><br />
    <p>
        <span style="font-size: large">Student ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><asp:TextBox ID="bxtUser" runat="server" MaxLength="10"></asp:TextBox>
        <br />
    </p>
    <p>
        <span style="font-size: large">First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><asp:TextBox ID="firstNamebox" runat="server" MaxLength="50"></asp:TextBox>
        <br />
    </p>
    <p>
        <span style="font-size: large">Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span><asp:TextBox ID="lastNameBox" runat="server" MaxLength="50"></asp:TextBox>
        <br />
    </p>
    <p>
        <span style="font-size: large" id ="periodlabel">Class Period:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
        <asp:DropDownList ID="periodList" runat="server" Height="35px" Width="129px">
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p style="height: 42px">
        <br />
        <span style="font-size: large">Password:</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="bxtPass" runat="server" OnTextChanged="bxtPass_TextChanged" TextMode="Password" MaxLength="50"></asp:TextBox>
    </p>
    <p>
        <br />
        <span style="font-size: large">Confirm Password:</span><asp:TextBox ID="bxtConfirm" runat="server" TextMode="Password" MaxLength="50"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" style="color: #FF0000" Text="Do Not Use Your FCPS Password"></asp:Label>
        <br />
        <asp:Label ID="errMessage" runat="server" style="font-size: large" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="butCreate" runat="server" OnClick="butCreate_Click" Text="Create User" />
        <br />
        <br />
        <br />
    </p>
    <br />
    <br />
</asp:Content>
