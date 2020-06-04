<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMasterPage.master" AutoEventWireup="true" CodeFile="checkpoint.aspx.cs" Inherits="checkpoint" %>

<%@ Register src="Controls/checkCode.ascx" tagname="checkCode" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
<h3 align="center" style="font-size: xx-large; color: #0000FF;">Email Id Verification </h3>
</div>
<div>

    <uc1:checkCode ID="checkCode1" runat="server" />

</div>
</asp:Content>

