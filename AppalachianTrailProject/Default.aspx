<%@ Page Title="TJHSST Appalachian Trail Challenge Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AppalachianTrailProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 style="color: #FFFFFF; background-color: #996633">The Appalachian Trail
                        Challenge</h1>
        <p style="color: #FFFFFF; background-color: #FFFFFF">
            <asp:Image ID="Image1" runat="server" ImageAlign="Baseline" ImageUrl="~/tjhsstLogo.jpg" />
            <asp:Image ID="Image2" runat="server" AlternateText="Appalachian Trail Logo" BackColor="White" EnableTheming="True" Height="167px" ImageAlign="Baseline" ImageUrl="~/AppTrailLogo.jpg" Width="184px" />
        </p>
        <p style="color: #FFFFFF; text-align: center; background-color: #994d00">
            <table class="nav-justified" style="background-color: #996633; color: #FFFFFF; width: 101%;">
                <tr>
                    <td class="text-center" style="width: 25%; height: 30px; font-size: xx-large;">2nd</td>
                    <td class="text-center" style="width: 25%; height: 30px; font-size: xx-large;">3rd</td>
                    <td class="text-center" style="height: 30px; width: 25%; font-size: xx-large;">4th</td>
                    <td class="text-center" style="height: 30px; width: 25%; font-size: xx-large;">7th</td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 25%">
                        <asp:Label ID="classMil2" runat="server" style="font-size: xx-large"></asp:Label>
                        <span style="font-size: xx-large">/2184</span></td>
                    <td class="text-center" style="width: 25%">
                        <asp:Label ID="classMil3" runat="server" style="font-size: xx-large"></asp:Label>
                        <span style="font-size: xx-large">/2184</span></td>
                    <td class="text-center" style="width: 25%">
                        <asp:Label ID="classMil4" runat="server" style="font-size: xx-large"></asp:Label>
                        <span style="font-size: xx-large">/2184</span></td>
                    <td class="text-center" style="width: 25%">
                        <asp:Label ID="classMil7" runat="server" style="font-size: xx-large"></asp:Label>
                        <span style="font-size: xx-large">/2184 </span></td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 25%">
                        <span style="font-size: xx-large">miles</span></td>
                    <td class="text-center" style="width: 25%">
                        <span style="font-size: xx-large">miles</span></td>
                    <td class="text-center" style="width: 25%">
                        <span style="font-size: xx-large">miles</span></td>
                    <td class="text-center" style="width: 25%">
                        <span style="font-size: xx-large">miles</span></td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 25%">
                        <asp:Label ID="comp2" runat="server" ForeColor="White" style="font-size: x-large" Visible="False">Period 2 Has Finished The Challenge</asp:Label>
                    </td>
                    <td class="text-center" style="width: 25%">
                        <asp:Label ID="comp3" runat="server" style="font-size: x-large" Visible="False">Period 3 Has Finished The Challenge</asp:Label>
                    </td>
                    <td class="text-center" style="width: 25%">
                        <asp:Label ID="comp4" runat="server" style="font-size: x-large" Visible="False">Period 4 Has Finished The Challenge</asp:Label>
                    </td>
                    <td class="text-center" style="width: 25%"> 
                        <asp:Label ID="comp7" runat="server" style="font-size: x-large" Visible="False">Period 7 Has Finished The Challenge</asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" colspan="4" style="font-size: x-large">
                        Mr. Arthurs Miles:
                        <asp:Label ID="teachMiles" runat="server"></asp:Label>
                        /2184</td>
                </tr>
                <tr>
                    <td class="text-center" colspan="4">
                        &nbsp;</td>
                </tr>
            </table>
        </p>
    </div>

    </asp:Content>
