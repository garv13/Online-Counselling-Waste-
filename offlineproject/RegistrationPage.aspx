<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="offlineproject.RegistrationPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 192px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>Roll Number</td>
            <td style="width: 410px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter User Id">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 26px">Name</td>
            <td style="width: 410px; height: 26px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            <td style="height: 26px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Name">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td style="width: 410px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Email Required" Display="Dynamic">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Correct Email Required" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
       <tr>
         <td class="auto-style1">Date Of Birth</td>
              
               <td class="auto-style1">
                   <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>  
              <td class="auto-style1"><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/calendar_icon1.png" OnClick="ImageButton1_Click" Width="22px" CausesValidation="False" />
                  <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" OnSelectionChanged="Calendar1_SelectionChanged" NextPrevFormat="ShortMonth">
                      <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                      <NextPrevStyle VerticalAlign="Bottom" />
                      <OtherMonthDayStyle ForeColor="#808080" />
                      <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                      <SelectorStyle BackColor="#CCCCCC" />
                      <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                      <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                      <WeekendDayStyle BackColor="#FFFFCC" />
                  </asp:Calendar>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Date Of Birth Required" Text="*" ControlToValidate="TextBox8" SetFocusOnError="True"></asp:RequiredFieldValidator>
               </td>
        </tr>
           <tr>
            <td>Password</td>
            <td style="width: 410px">
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Password Required"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Password Format Does'nt Match" ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Confirm Password</td>
            <td style="width: 410px">
                <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox></td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="Passwords Do Not Match" SetFocusOnError="True"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td style="width: 410px">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Choose Atleast One">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
           <td>Category</td>
             <td><asp:DropDownList ID="DropDownList2" runat="server">
                 <asp:ListItem>Select Category</asp:ListItem>
                 <asp:ListItem>General</asp:ListItem>
                 <asp:ListItem>OBC</asp:ListItem>
                 <asp:ListItem>SC</asp:ListItem>
                 <asp:ListItem>ST</asp:ListItem>
                 </asp:DropDownList></td>
        </tr>
        <tr>
            <td>Contact No.</td>
            <td style="width: 410px">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" Display="Dynamic" ErrorMessage="Contact No. Required">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox6" Display="Dynamic" ErrorMessage="Enter Valid Contact Number" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="height: 26px">State</td>
            <td style="width: 410px; height: 26px;">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Value="0">Select State</asp:ListItem>
                    <asp:ListItem>Jammu And Kashmir</asp:ListItem>
                    <asp:ListItem>Himachal</asp:ListItem>
                    <asp:ListItem>Punjab</asp:ListItem>
                    <asp:ListItem>Haryana</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                    <asp:ListItem>Others</asp:ListItem>
                </asp:DropDownList></td>
            <td style="height: 26px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Choose Atleast One State" InitialValue="0">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="h40">Address</td>
            <td style="width: 410px; height: 40px;">
                <asp:TextBox ID="TextBox7" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            <td class="h40">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox7" ErrorMessage="Address Required">*</asp:RequiredFieldValidator>
            </td>
        </tr>

        <tr>
                <td>
                    Security Code :
                </td>
                <td>
                  <asp:Image ID="imgCaptcha" runat="server" ImageUrl="~/CaptchaImage.aspx" />
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:TextBox ID="txtCaptchaText" runat="server" Width="100px" /> [Type Security code here]
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Label ID="lblMessage" runat="server" />
                </td>
            </tr> 
        <tr>    
        <td style="width: 410px" colspan="3" >
                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" style="text-align: center;" CssClass="Button"/></td>
            </tr>
    </table>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Content>
