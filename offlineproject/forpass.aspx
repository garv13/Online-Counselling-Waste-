<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="forpass.aspx.cs" Inherits="offlineproject.forpass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <body>
<h2 class="pagetitle">Forgot Password</h2>
<div><center>

<table cellspacing="2" cellpadding="2" border="0">

<tr><td><b>Enter Your Email:</b></td><td><asp:TextBox ID="txtEmail" runat="server" /></td></tr>
<tr><td></td><td><asp:button ID="btnSubmit" Text="Submit"  runat="server" onclick="btnSubmit_Click"/></td></tr>
<tr><td colspan="2" "><asp:Label ID="lbltxt" runat="server"/></td></tr>
</table>
    </center>
</div>
</body>
</asp:Content>

