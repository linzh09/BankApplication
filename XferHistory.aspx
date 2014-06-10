<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="XferHistory.aspx.cs" Inherits="XferHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 80%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="myHeading">
                Transfer History:</td>
        </tr>
        <tr>
            <td align="center">
                <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:GridView ID="gv1" runat="server">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

