<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="offlineproject.test" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style1">
                <tr>
                    <td>College</td>
                    <td>Branch</td>
                    <td>New Branch</td>
                    <td>New Seats</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1">
                        </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [name] FROM [College]"></asp:SqlDataSource>

                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [branch] FROM [College] WHERE ([seats] IS NOT NULL)"></asp:SqlDataSource>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                      </td>


                </tr>
            </table>
            <div style="text-align:center;" >
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Back" ClientIDMode="AutoID" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Add Branch" ClientIDMode="AutoID" />

        </div>
   </div>
    </form>
</body>
</html>
