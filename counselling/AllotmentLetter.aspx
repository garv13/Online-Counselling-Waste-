<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AllotmentLetter.aspx.cs" Inherits="AllotmentLetter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center><b>Provisional Allotment Letter</b><asp:Panel ID="Panel1" runat="server" BorderStyle="Outset">
    Roll No:<asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    Name :<asp:Label ID="Label2" runat="server"></asp:Label>
    <br />
    Address:<asp:Label ID="Label3" runat="server"></asp:Label>
    <br />
    Rank:<asp:Label ID="Label4" runat="server"></asp:Label>
    <br />
    Gender:<asp:Label ID="Label5" runat="server"></asp:Label>
    <br />
    Category:<asp:Label ID="Label6" runat="server"></asp:Label>
    </asp:Panel>
    It is to informed that based upon the choices opted by you,you have been alloted the following insitute and branch.
<asp:Panel ID="Panel2" runat="server" BorderStyle="Solid">
    Alloted Institute:<asp:Label ID="Label7" runat="server"></asp:Label>
    <br />
    Alloted Branch:<asp:Label ID="Label8" runat="server"></asp:Label>
    <br />
    Choice No.:<asp:Label ID="Label9" runat="server"></asp:Label>
    </asp:Panel>    
    The offer of allotment of seat is purely provisional and is subject to conditions mentioned int the admission information brochure and fulfilling of all eligibility conditions.
    <br />
    The candidate is required to deposit the fees of 40,000 before due date.
    The Amount should be deposited in the designated branch of axis bank in favour of University Registrar after generating challan from the website,failing in which,you will lose any claim for this alloted seat and thereafter.Those who failed to deposit this amount should not be considered further for any subsequent round.
    For any further doubts,contact admin. 
</center>
</asp:Content>

