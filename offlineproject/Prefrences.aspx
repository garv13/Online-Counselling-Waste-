<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="Prefrences.aspx.cs" Inherits="offlineproject.Prefrences" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 85px;
        }
        .auto-style2 {
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="pagetitle">Prefrence List</h1>
    <h4 style="width: 196px; height: 31px; margin-bottom: 4px; margin-right: 0px;" >&nbsp;Selection List</h4>
    <table style="border-style: groove; border-width: inherit; border-color: #000000; ; width: 350px; margin-top: 0px; height: 508px;">
        <tr>
            <td class="auto-style2" style="border-style: groove">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style2" style="border-style: inherit">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/del.jpg" OnClick="ImageButton1_Click1" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-style: groove" >
                <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style2" style="border-style: inherit" >
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/del.jpg" OnClick="ImageButton2_Click" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-style: groove">
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style2" style="border-style: inherit">
                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/del.jpg" OnClick="ImageButton3_Click" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-style: groove">
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style2" style="border-style: inherit">
                <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/images/del.jpg" OnClick="ImageButton4_Click" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-style: groove">
                <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style2" style="border-style: inherit">
                <asp:ImageButton ID="ImageButton5" runat="server" ImageUrl="~/images/del.jpg" OnClick="ImageButton5_Click" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-style: groove">
                <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style2" style="border-style: inherit">
                <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/images/del.jpg" OnClick="ImageButton6_Click" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-style: groove">
                <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style2" style="border-style: inherit">
                <asp:ImageButton ID="ImageButton7" runat="server" ImageUrl="~/images/del.jpg" OnClick="ImageButton7_Click" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-style: groove">
                <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style2" style="border-style: inherit">
                <asp:ImageButton ID="ImageButton8" runat="server" ImageUrl="~/images/del.jpg" OnClick="ImageButton8_Click" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-style: groove">
                <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style2" style="border-style: inherit">
                <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/images/del.jpg" OnClick="ImageButton9_Click" Visible="False" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="border-style: groove">
                <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style2" style="border-style: inherit">
                <asp:ImageButton ID="ImageButton10" runat="server" ImageUrl="~/images/del.jpg" OnClick="ImageButton10_Click" Visible="False" />
            </td>
        </tr>
    <tr> <td class="auto-style2" style="border-style: groove" colspan="2">
    <asp:Button ID="Button1" runat="server" Text="Clear" OnClick="Button1_Click" Width="93px" CssClass="Button" />

    <asp:Button ID="Button2" runat="server" Text="Save" Width="91px" CssClass="Button" OnClick="Button2_Click" />

    <asp:Button ID="Button3" runat="server" Text="Update" Width="107px" OnClick="Button3_Click1" CssClass="Button" />

    <br />
        <asp:Label ID="Label21" runat="server" Text="List is Complete , Click Update to Make Changes If Any, Otherwise Click Save" Visible="False"></asp:Label>
        <br />
        </td></tr> 
        </table>
    <table style=" width: 299px;" >
        <tr > <td colspan="2"><h4>College List</h4></td></tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label11" runat="server" Text="AMITY"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Please Select</asp:ListItem>
                    <asp:ListItem Value="CSE">Computer Science</asp:ListItem>
                    <asp:ListItem Value="IT">Information Technology</asp:ListItem>
                    <asp:ListItem Value="ECE">Electronic and Communication</asp:ListItem>
                    <asp:ListItem Value="ME">Mechanical</asp:ListItem>
                    <asp:ListItem Value="EE">Electrical </asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button6" runat="server" Text="Add" OnClick="button6" CssClass="myButton" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label12" runat="server" Text="AMBEDKAR"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>Please Select</asp:ListItem>
                    <asp:ListItem Value="CSE">Computer Science</asp:ListItem>
                    <asp:ListItem Value="IT">Information Technology</asp:ListItem>
                    <asp:ListItem Value="ECE">Electronic and Communication</asp:ListItem>
                    <asp:ListItem Value="ME">Mechanical</asp:ListItem>
                    <asp:ListItem Value="EE">Electrical </asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button7" runat="server" Text="Add" OnClick="Button7_Click" CssClass="myButton" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label13" runat="server" Text="BHARTI VP"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>Please Select</asp:ListItem>
                    <asp:ListItem Value="CSE">Computer Science</asp:ListItem>
                    <asp:ListItem Value="IT">Information Technology</asp:ListItem>
                    <asp:ListItem Value="ECE">Electronic and Communication</asp:ListItem>
                    <asp:ListItem Value="ME">Mechanical</asp:ListItem>
                    <asp:ListItem Value="EE">Electrical </asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button8" runat="server" Text="Add" OnClick="Button8_Click" CssClass="myButton" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label14" runat="server" Text="GB Pant"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>Please Select</asp:ListItem>
                    <asp:ListItem Value="CSE">Computer Science</asp:ListItem>
                    <asp:ListItem Value="IT">Information Technology</asp:ListItem>
                    <asp:ListItem Value="ECE">Electronic and Communication</asp:ListItem>
                    <asp:ListItem Value="ME">Mechanical</asp:ListItem>
                    <asp:ListItem Value="EE">Electrical </asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button9" runat="server" Text="Add" OnClick="Button9_Click" CssClass="myButton" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label15" runat="server" Text="GTBIT"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList5" runat="server">
                    <asp:ListItem>Please Select</asp:ListItem>
                    <asp:ListItem Value="CSE">Computer Science</asp:ListItem>
                    <asp:ListItem Value="IT">Information Technology</asp:ListItem>
                    <asp:ListItem Value="ECE">Electronic and Communication</asp:ListItem>
                    <asp:ListItem Value="ME">Mechanical</asp:ListItem>
                    <asp:ListItem Value="EE">Electrical </asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button10" runat="server" Text="Add" OnClick="Button10_Click" CssClass="myButton" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label16" runat="server" Text="NIEC"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList6" runat="server">
                    <asp:ListItem>Please Select</asp:ListItem>
                    <asp:ListItem Value="CSE">Computer Science</asp:ListItem>
                    <asp:ListItem Value="IT">Information Technology</asp:ListItem>
                    <asp:ListItem Value="ECE">Electronic and Communication</asp:ListItem>
                    <asp:ListItem Value="ME">Mechanical</asp:ListItem>
                    <asp:ListItem Value="EE">Electrical </asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button11" runat="server" Text="Add" OnClick="Button11_Click" CssClass="myButton" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label17" runat="server" Text="BPIT"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList7" runat="server">
                    <asp:ListItem>Please Select</asp:ListItem>
                    <asp:ListItem Value="CSE">Computer Science</asp:ListItem>
                    <asp:ListItem Value="IT">Information Technology</asp:ListItem>
                    <asp:ListItem Value="ECE">Electronic and Communication</asp:ListItem>
                    <asp:ListItem Value="ME">Mechanical</asp:ListItem>
                    <asp:ListItem Value="EE">Electrical </asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button12" runat="server" Text="Add" OnClick="Button12_Click" CssClass="myButton" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label18" runat="server" Text="MSIT"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList8" runat="server">
                    <asp:ListItem>Please Select</asp:ListItem>
                    <asp:ListItem Value="CSE">Computer Science</asp:ListItem>
                    <asp:ListItem Value="IT">Information Technology</asp:ListItem>
                    <asp:ListItem Value="ECE">Electronic and Communication</asp:ListItem>
                    <asp:ListItem Value="ME">Mechanical</asp:ListItem>
                    <asp:ListItem Value="EE">Electrical </asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button13" runat="server" Text="Add" OnClick="Button13_Click" CssClass="myButton" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label19" runat="server" Text="MAIT"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList9" runat="server">
                    <asp:ListItem>Please Select</asp:ListItem>
                    <asp:ListItem Value="CSE">Computer Science</asp:ListItem>
                    <asp:ListItem Value="IT">Information Technology</asp:ListItem>
                    <asp:ListItem Value="ECE">Electronic and Communication</asp:ListItem>
                    <asp:ListItem Value="ME">Mechanical</asp:ListItem>
                    <asp:ListItem Value="EE">Electrical </asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button5" runat="server" Text="Add" OnClick="Button5_Click" CssClass="myButton" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label20" runat="server" Text="HMR"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList10" runat="server">
                    <asp:ListItem>Please Select</asp:ListItem>
                    <asp:ListItem Value="CSE">Computer Science</asp:ListItem>
                    <asp:ListItem Value="IT">Information Technology</asp:ListItem>
                    <asp:ListItem Value="ECE">Electronic and Communication</asp:ListItem>
                    <asp:ListItem Value="ME">Mechanical</asp:ListItem>
                    <asp:ListItem Value="EE">Electrical </asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button14" runat="server" Text="Add" OnClick="Button14_Click" CssClass="myButton" />
            </td>
        </tr>
    </table>
    <br />
    
    <br />
            
    
</asp:Content>