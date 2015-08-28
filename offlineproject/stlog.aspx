<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="stlog.aspx.cs" Inherits="offlineproject.stlog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <h2 class="pagetitle">Welcome</h2>
    <p style="font-size:30px"> Since You have Registered , Now You are eligible For The Filling the Prefrence list</p>
<p style="font-size:30px"> Now Click The Button Below For Prefrence List Page for the Further Couselling</p>
    <asp:Button ID="Button1" runat="server" Text="Fill Choices" CssClass="Button" PostBackUrl="~/Prefrences.aspx" />
    <p style="font-size:30px;color:red">* Prefrence List should be properly filled . this List will be your Final List of Allocation </p>
</asp:Content> 

