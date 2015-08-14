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
               <td><b>Student Login ID</b></td>
               <td><asp:TextBox ID="Textid" runat="server"></asp:TextBox></td>

               <td class="auto-style2">
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Correct Login id" ControlToValidate="Textid" Display="Dynamic">*</asp:RequiredFieldValidator>
               </td>

           </tr>
           <tr>
               <td>
                  <b>Password</b>
               </td>
               <td>
                   <asp:TextBox ID="Textpwd" runat="server"></asp:TextBox>
               </td>
               <td class="auto-style2">
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Textpwd" ErrorMessage="Enter Correct Password">*</asp:RequiredFieldValidator>
               </td>
           </tr>
           <tr>
               <td colspan="2"> <center><asp:Button ID="Button1" runat="server" Text="Login" CssClass="Button"></asp:Button></center></td>
               <td class="auto-style2"> &nbsp;</td>
           </tr>
          
       </table>
       <h2> OR</h2>
       

       <table class="auto-style1">
           <tr>
               <td><b>Phone Number</b></td>
               <td><asp:TextBox  runat="server" ID="txtph"></asp:TextBox></td>
               <td>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Correct Number" ControlToValidate="txtph">*</asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter Correct Number" ControlToValidate="txtph" ValidationExpression="[0-9]{10}">*</asp:RegularExpressionValidator>
               </td>
           </tr>
           <tr>
               <td><b>Password</b></td>
               <td><asp:TextBox runat="server" ID="txtpwd2"></asp:TextBox></td>
               <td>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter Correct Password" ControlToValidate="txtpwd2">*</asp:RequiredFieldValidator>
               </td>
           </tr>
           <tr>
               <td colspan="2"><center><asp:Button ID="Button3" runat="server" Text="Log In" CssClass="Button"></asp:Button>
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
        <asp:ValidationSummary ID="ValidationSummary1" runat="server"></asp:ValidationSummary>
       

   </center> 
</asp:Content>
