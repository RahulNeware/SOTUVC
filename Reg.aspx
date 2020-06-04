<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMasterPage.master" AutoEventWireup="true" CodeFile="Reg.aspx.cs" Inherits="Reg" %>

<%@ Register src="Controls/RegControl.ascx" tagname="RegControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<h3 align="center" style="font-size: xx-large; color: #0000FF;">New User Registration</h3>
</div>
<div>
    <uc1:RegControl ID="RegControl1" runat="server" />
</div>
</asp:Content>

