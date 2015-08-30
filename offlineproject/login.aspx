<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="offlineproject.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        
        .auto-style1 {
            width: 5px;
        }
        .auto-style2 {
            width: 28px;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="pagetitle">&nbsp;&nbsp;&nbsp;&nbsp; Log In</h1>
    <center>
       <table>
           <tr>
               <td><b>Roll Number</b>&nbsp;</td>
               <td><asp:TextBox ID="Textid" runat="server"></asp:TextBox></td>

               <td class="auto-style2">
                   
               </td>

           </tr>
           <tr>
               <td>
                  <b>Password</b>
               </td>
               <td>
                   <asp:TextBox ID="Textpwd" runat="server" TextMode="Password"></asp:TextBox>
               </td>
               <td class="auto-style2">
               </td>
           </tr>
           <tr>
               <td colspan="2"> <center><asp:Button ID="Button1" runat="server" Text="Login" CssClass="Button" OnClick="Button1_Click"></asp:Button></center></td>
               <td class="auto-style2"> &nbsp;</td>
           </tr>
          
       </table>
       <h2> OR</h2>
       

       <table class="auto-style1">
           <tr>
               <td><b>Phone Number</b></td>
               <td><asp:TextBox  runat="server" ID="txtph"></asp:TextBox></td>
               <td>
               </td>
           </tr>
           <tr>
               <td><b>Password</b></td>
               <td><asp:TextBox runat="server" ID="txtpwd2" TextMode="Password"></asp:TextBox></td>
               <td>
               </td>
           </tr>
           <tr>
               <td colspan="2"><center><asp:Button ID="Button3" runat="server" Text="Log In" CssClass="Button" OnClick="Button3_Click"></asp:Button>
                   <br />
                   </center></td>
               <td>&nbsp;</td>
           </tr>
       </table>
       <table>
            <tr>
               <td colspan="2"> <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/forpass.aspx"><b>Forgot Password , Click Here</b></asp:HyperLink></td>
           </tr>
           <tr>
               <td colspan="2"> <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/RegistrationPage.aspx"><b>Not Regsitered , Click Here</b></asp:HyperLink></td>
           </tr>
       </table>
       

   </center> 
</asp:Content>
