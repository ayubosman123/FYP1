<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="DefaultCust.aspx.cs" Inherits="DefaultCust" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
<p>
</p>
<asp:ListBox ID="lstCust" runat="server" Height="105px" Width="1447px"></asp:ListBox>
<p>
    <asp:Button ID="btnAddCustomer" runat="server" Height="28px" Text="AddCustomer" Width="297px" OnClick="btnAddCustomer_Click" />
&nbsp;
    &nbsp;<asp:Button ID="btnEdit" runat="server" Height="22px" OnClick="btnEdit_Click" style="margin-top: 0px" Text="Edit Customer" Width="199px" />
    <asp:Button ID="btnDeleteCustomer" runat="server" Text="Delete Customer" OnClick="btnDeleteCustomer_Click" style="margin-left: 32px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    <asp:Label ID="lblFilterEmail" runat="server" Text="Please enter email"></asp:Label>
</p>
<p>
&nbsp;
    <asp:TextBox ID="txtFilter" runat="server" Height="16px" Width="272px"></asp:TextBox>
&nbsp;<asp:Button ID="btnFilterEmail" runat="server" Text="Filter by Email" OnClick="btnFilterEmail_Click" />
&nbsp;&nbsp;
    <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" OnClick="btnDisplayAll_Click" />
</p>
<p>
    &nbsp;</p>
<p>
    <asp:Label ID="lblError" runat="server"></asp:Label>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>

