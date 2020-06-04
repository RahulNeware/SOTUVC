<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMasterPage.master" AutoEventWireup="true" CodeFile="vcp.aspx.cs" Inherits="vcp" %>

<%@ Register src="Controls/vcpControl.ascx" tagname="vcpControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
<h3 align="center" style="font-size: xx-large; color: #0000FF;">VC Page 
    
        </h3>
</div>
<div>
    <uc1:vcpControl ID="vcpControl1" runat="server" />
</div>
</asp:Content>

