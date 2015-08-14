<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addCollege.aspx.cs" Inherits="offlineproject.addCollege" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" visible="true">
    <div id="main" runat="server" style="align-content:center; text-align:center; vertical-align:central;">
    
        <asp:Button ID="Button1" runat="server" OnClick="back" Text="Back" />
        <asp:Button ID="Button2" runat="server" Text="Add new College" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Add new Branch" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="Update Seats" OnClick="Button4_Click" />
    </div>
        <div id="seat" runat="server" visible="false">
             <table align="center" class="auto-style1">
                <tr>
                    <td>College</td>
                    <td>Branch</td>
                    <td>Total Seats</td>
                    <td>Seats Left</td>
                    <td>New Seats</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="name">
                        </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [name] FROM [College]"></asp:SqlDataSource>

                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="branch">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [branch] FROM [College]"></asp:SqlDataSource>
                    </td>
                    <td>
                        <asp:TextBox ID="seatTotal" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="seatLeft" runat="server">

                        </asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="newSeats" runat="server"></asp:TextBox>
                    </td>

                </tr>
            </table>
            <div style="text-align:center;" >
            <asp:Button ID="Button5" runat="server" OnClick="Button1_Click" Text="Back" ClientIDMode="AutoID" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Update Seats" ClientIDMode="AutoID" />
                <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Get Status" />
        </div>
            </div>
        <div id="coll" runat="server" visible="false" >
             <div style="text-align:center;margin-top:20px">
    
        <asp:TextBox ID="nameColl" runat="server" placeholder="Name"></asp:TextBox>
        <asp:TextBox ID="branchColl" runat="server" placeholder="Branch"></asp:TextBox>
        <asp:TextBox ID="seatColl" runat="server" placeholder="Seats" ></asp:TextBox>
    </div>
        <div style="text-align:center">
            <asp:Button ID="Button7" runat="server" Text="Back" OnClick="Button1_Click" />
            <asp:Button ID="Button8" runat="server" Text="Add" OnClick="Button8_Click" />
        </div>
        </div>
        <div id="bran" runat="server" visible="false">

                <table align="center" class="auto-style1">
                <tr>
                    <td>College</td>
                    <td>Branch</td>
                    <td>New Branch</td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Seats</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource5" DataTextField="name">
                        </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [name] FROM [College]"></asp:SqlDataSource>

                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource6" DataTextField="branch">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [branch] FROM [College]"></asp:SqlDataSource>
                    </td>
                    <td>
                        <asp:TextBox ID="newBranch" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="seats" runat="server"></asp:TextBox>
                      </td>


                </tr>
            </table>
            <div style="text-align:center;" >
            <asp:Button ID="Button9" runat="server" OnClick="Button1_Click" Text="Back" ClientIDMode="AutoID" />
            <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Add Branch" ClientIDMode="AutoID" />

        </div>

        </div>
        <p>
            <asp:Button ID="Button12" runat="server" Text="Button" OnClick="prefrence" />
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
