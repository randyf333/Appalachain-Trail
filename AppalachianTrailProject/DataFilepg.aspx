<%@ Page Title="TJHSST Appalachian Trail Challenge" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataFilepg.aspx.cs" Inherits="AppalachianTrailProject.DataFilepg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p style="font-size: xx-large">
        Select The File Date</p>
    <p>
        <table style="width:100%;">
            <tr>
                <td style="width: 394px; height: 54px"></td>
                <td rowspan="3" style="width: 226px">
                    <asp:Calendar ID="Calendar1" runat="server" style="margin-left: 0px"></asp:Calendar>
                </td>
                <td rowspan="3">Each Line is One Entry</td>
            </tr>
            <tr>
                <td style="width: 394px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 394px">&nbsp;</td>
            </tr>
        </table>
    </p>
    <p>
        <asp:LinkButton ID="fileButton" runat="server" OnClick="fileButton_Click">Get Files</asp:LinkButton>
    </p>
    <p>
        <asp:Label ID="errFile" runat="server" ForeColor="Red"></asp:Label>
    </p>
</asp:Content>
