<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 500px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="myHeading">
                Please Login:</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right">
                Username</td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                Password</td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="mainButton" 
                    onclick="btnLogin_Click" />
            </td>
        </tr>
        <tr>
            <td align="right">
                &nbsp;</td>
            <td>
                <asp:Label ID="lblStatus" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

