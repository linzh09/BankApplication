<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="XferChkToSav.aspx.cs" Inherits="XferChkToSav" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 600px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1">
        <tr>
            <td class="myHeading" colspan="3">
                Transfer Money from Checking to Savings:</td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td align="right">
                Checking Balance</td>
            <td>
                <asp:Label ID="lblCheckingBalance" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td align="right">
                Saving Balance</td>
            <td>
                <asp:Label ID="lblSavingBalance" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td align="right">
                Amount To Transfer
                <asp:TextBox ID="txtAmount" runat="server" MaxLength="4" Width="70px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnTransfer" runat="server" CssClass="mainButton" 
                    Text="Transfer to Savings" onclick="btnTransfer_Click" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="lblStatus" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

