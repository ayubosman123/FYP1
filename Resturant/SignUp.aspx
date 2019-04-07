<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblfirstname" runat="server" Text="First Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbllastname" runat="server" Text="Last Name"></asp:Label>
&nbsp;<asp:TextBox ID="txtsurname" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblemail" runat="server" Text="Email "></asp:Label>
&nbsp;<asp:TextBox ID="txteMail" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbltitle" runat="server" Text="Title "></asp:Label>
&nbsp;<asp:TextBox ID="txttitle" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblgender" runat="server" Text="Gender"></asp:Label>
&nbsp;<asp:TextBox ID="txtgender" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbldob" runat="server" Text="Date of Birth"></asp:Label>
&nbsp;<asp:TextBox ID="txtdateOfBirth" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblcontactno" runat="server" Text="Contact No"></asp:Label>
&nbsp;<asp:TextBox ID="txtContactNumber" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblhouseno" runat="server" Text="House No "></asp:Label>
&nbsp;<asp:TextBox ID="txtHouseno" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblpostcode" runat="server" Text="Post Code"></asp:Label>
&nbsp;<asp:TextBox ID="txtpostCode" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnEnter" runat="server" Height="41px" Text="Enter " Width="231px" OnClick="btnEnter_Click" />
    <br />
    <br />
    <asp:Label ID="lblError" runat="server"></asp:Label>
    <br />
</asp:Content>

