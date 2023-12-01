<%@ Page Title="TJHSST Appalachian Trail Challenge" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="YourDatapg.aspx.cs" Inherits="AppalachianTrailProject.Your_Datapg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table dir="ltr" style="width: 100%; height: 100%; clip: rect(auto, auto, auto, auto);">
        <caption class="text-center">
            </caption>
        <tr>
            <td colspan="3" style="font-size: xx-large; text-align: center;">Welcome
                <asp:Label ID="nameText" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 360px; font-size: large; text-align: center;">Enter Your # Of Steps Here</td>
            <td style="width: 369px; font-size: x-large; text-align: center;">Your Stats</td>
            <td style="font-size: large; text-align: center;">To Convert Your Activity To Steps</td>
        </tr>
        <tr>
            <td style="width: 360px; text-align: center;">
                <asp:TextBox ID="entBox" runat="server" Height="27px" OnTextChanged="entBox_TextChanged" Width="170px"></asp:TextBox>
            </td>
            <td style="width: 369px; font-size: large; text-align: center;">You&#39;ve Logged
                <asp:Label ID="mileLabel" runat="server"></asp:Label>
                miles</td>
            <td style="text-align: center">
                <asp:HyperLink ID="conLink" runat="server" NavigateUrl=" https://www.pehp.org/mango/pdf/pehp/pdc/step%20conversion%20chart_FFB805BB.pdf" style="font-size: large" Target="_blank">Click Here</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 61px; width: 360px; text-align: center;">
                <asp:Button ID="entButton" runat="server" Height="34px" OnClick="entButton_Click" Text="Enter" Width="112px" />
            </td>
            <td style="height: 61px; width: 369px; font-size: large; text-align: center;">You&#39;ve Logged <asp:Label ID="mileLabel2" runat="server"></asp:Label>
                Of Your Classes
                <asp:Label ID="classMil" runat="server"></asp:Label>
                miles</td>
            <td style="height: 61px">
                <asp:HyperLink ID="dataLink" runat="server" NavigateUrl="~/DataFilepg.aspx" Visible="False">All Students Data</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td style="width: 360px; text-align: center;">
                <asp:Label ID="enterMess" runat="server"></asp:Label>
            </td>
            <td style="width: 369px; font-size: large; color: #000000; text-align: center;">Keep It Up!</td>
            <td>
                <asp:HyperLink ID="resetLink" runat="server" NavigateUrl="~/ResetPg.aspx" Visible="False">Reset Passwords</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>
