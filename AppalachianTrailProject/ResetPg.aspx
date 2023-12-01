<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResetPg.aspx.cs" Inherits="AppalachianTrailProject.ResetPg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%; height: 169px;">
        <tr>
            <td><span style="font-size: x-large">Rest ID&nbsp;&nbsp; </span><asp:TextBox ID="resetID" runat="server" Height="25px" Width="152px" MaxLength="10"></asp:TextBox>
                <br />
                <asp:Label ID="resetMess" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="resetBut" runat="server" OnClick="resetBut_Click" Text="Reset" />
            </td>
        </tr>
    </table>
</asp:Content>
