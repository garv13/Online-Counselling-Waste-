<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="offlineproject.admin" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="align-content:center; font-size:30px; font-family:'Segoe UI'; text-align:center">Admin Page</h1>   
    </div>
        <div>
           
            <table align="center" class="auto-style1">
                <tr>
                    <td>College</td>
                    <td>Branch</td>
                    <td>Total Seats</td>
                    <td>Seats Left</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="name">
                        </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [name] FROM [College]"></asp:SqlDataSource>

                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [branch] FROM [College] WHERE ([seats] IS NOT NULL)"></asp:SqlDataSource>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Text="<%$ RouteValue:SqlDataSource3 %>"></asp:TextBox>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [seats] FROM [College] WHERE (([name] = @name) AND ([branch] = @branch))">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DropDownList1" Name="name" PropertyName="SelectedValue" Type="String" />
                                <asp:ControlParameter ControlID="DropDownList2" Name="branch" PropertyName="SelectedValue" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Text="<%$ ConnectionStrings:connect %>"></asp:TextBox>
                        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [seats left] AS seats_left FROM [College] WHERE (([branch] = @branch) AND ([name] = @name))">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DropDownList2" Name="branch" PropertyName="SelectedValue" Type="String" />
                                <asp:ControlParameter ControlID="DropDownList1" Name="name" PropertyName="SelectedValue" Type="String" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </td>
                    <td>&nbsp;</td>

                </tr>
            </table>
            <div style="text-align:center;" >
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add  New Item" ClientIDMode="AutoID" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete College" ClientIDMode="AutoID" />

        &nbsp;<br />
        </div>
            </div>

        
    <div id="calc" style="align-content:center;text-align:center">
      
        </div>
        <asp:GridView ID="GridView1" runat="server" Visible="False" AutoGenerateColumns="False" DataSourceID="SqlDataSource5">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        First Name
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblfirstname" runat="server" Text='<%#Eval("firstName") %>'></asp:Label>
                    </ItemTemplate>
                         </asp:TemplateField>
                <asp:TemplateField>
                     <HeaderTemplate>
                        rank
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblrank" runat="server" Text='<%#Eval("rank") %>'></asp:Label>
                    </ItemTemplate> 
                    </asp:TemplateField>
                    <asp:TemplateField>
                    <HeaderTemplate>
                        allot
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblallot" runat="server" Text='<%#Eval("allot") %>'></asp:Label>
                    </ItemTemplate> 
                        </asp:TemplateField>
                        <asp:TemplateField>
                    <HeaderTemplate>
                        selected
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblselected" runat="server" Text='<%#Eval("selected") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [firstName], [rank], [allot], [selected] FROM [Student] ORDER BY [rank]"></asp:SqlDataSource>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource6" Visible="false">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                         Name
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblname" runat="server" Text='<%#Eval("name") %>'></asp:Label>
                    </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField>
                     <HeaderTemplate>
                       seats left
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblseatsleft" runat="server" Text='<%#Eval("seatsleft") %>'></asp:Label>
                    </ItemTemplate> 
                    </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                        branch
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblbranch" runat="server" Text='<%#Eval("branch") %>'></asp:Label>
                    </ItemTemplate> 
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

         <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:connect %>" SelectCommand="SELECT [name], [seatsleft], [branch] FROM [College]"></asp:SqlDataSource>

         </form>
    
</body>
</html>
