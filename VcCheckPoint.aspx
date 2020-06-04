<%@ Page Title="" Language="C#" MasterPageFile="~/LoginMasterPage.master" AutoEventWireup="true" CodeFile="VcCheckPoint.aspx.cs" Inherits="VcCheckPoint" %>

<%@ Register src="VCCheckTool.ascx" tagname="VCCheckTool" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
<h3 align="center" style="font-size: xx-large; color: #0000FF;">Welcome to Visual Cryptography Check Point
<br>User Name :<asp:Label ID="Label1" runat="server" Text="Label" 
        ForeColor="#FF0066"></asp:Label></h3>
</div>
<div>
    
    <uc1:VCCheckTool ID="VCCheckTool1" runat="server" />
    
</div>
</asp:Content>

