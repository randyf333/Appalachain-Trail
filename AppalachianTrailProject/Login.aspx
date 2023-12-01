<%@ Page Title="TJHSST Appalachian Trail Challenge" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppalachianTrailProject.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <span style="font-size: large">&nbsp;<asp:Label ID="createLab" runat="server" Text="User Created" Visible="False"></asp:Label>
        </span></p>
    <p>
        <asp:LinkButton ID="createBut" runat="server" PostBackUrl="~/CreateUser.aspx">Click Here to Create Account</asp:LinkButton>
    </p>
    <p>
        <span style="font-size: large">&nbsp;&nbsp;&nbsp;&nbsp; Student ID:</span>
        <asp:TextBox ID="logName" runat="server" MaxLength="10"></asp:TextBox>
        <span style="font-size: large">&nbsp;&nbsp;&nbsp;&nbsp; </span>&nbsp;</p>
    <p>
        <span style="font-size: large">Password:</span>
        <asp:TextBox ID="logPass" runat="server" TextMode="Password" MaxLength="50"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="loginFail" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="logBut" runat="server" Height="45px" OnClick="logBut_Click" Text="Login" Width="83px" />
    </p>
</asp:Content>
