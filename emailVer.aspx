<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMasterPage.master" AutoEventWireup="true" CodeFile="emailVer.aspx.cs" Inherits="emailVer" %>

<%@ Register src="Controls/CodeVer.ascx" tagname="CodeVer" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
<h3 align="center" style="font-size: xx-large; color: #0000FF;">Email Id verification </h3>
</div>
<div>

    <uc1:CodeVer ID="CodeVer1" runat="server" />

</div>
</asp:Content>

