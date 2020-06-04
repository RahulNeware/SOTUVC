<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMasterPage.master" AutoEventWireup="true" CodeFile="TransDetails.aspx.cs" Inherits="TransDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 222px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td colspan="3">
                <asp:Table ID="Table1" runat="server" GridLines="Both" Height="33px" 
                    Width="770px" HorizontalAlign="Justify">
                    <asp:TableRow runat="server" ForeColor="Blue">
                        <asp:TableCell runat="server">Sr.</asp:TableCell>
                        <asp:TableCell runat="server">Transaction Details</asp:TableCell>
                        <asp:TableCell runat="server">Date</asp:TableCell>
                        <asp:TableCell runat="server">Credit</asp:TableCell>
                        <asp:TableCell runat="server">Debit</asp:TableCell>
                        <asp:TableCell runat="server">Balance Amt.</asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

