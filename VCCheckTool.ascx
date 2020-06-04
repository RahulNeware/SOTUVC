<%@ Control Language="C#" AutoEventWireup="true" CodeFile="VCCheckTool.ascx.cs" Inherits="VCCheckTool" %>
<style type="text/css">

* {
	margin: 0;
	padding: 0;
}

img {
	border: none;
}

        .style1
        {
            width: 236px;
        }
    </style>
	<asp:UpdatePanel ID="UpdatePanel3" runat="server">
        <ContentTemplate >
    <table style="width: 46%; color: #000000;">
        <tr>
            <td align="center">
                &nbsp;</td>
            <td align="center" colspan="3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style1">
                Load Your Visual&nbsp; Cryptography Image</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnUpload" runat="server" onclick="btnUpload_Click" 
                    Text="Upload" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Image ID="Image2" runat="server" Height="153px" Width="235px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnVerify" runat="server" onclick="btnVerify_Click" 
                    Text="Verify" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
	 </ContentTemplate>
            <Triggers>
                <asp:PostBackTrigger ControlID="btnUpload" />
            </Triggers>
</asp:UpdatePanel>

