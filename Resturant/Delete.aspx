<%@ Page Title="" Language="C#" MasterPageFile="~/ResturantMasterPage.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        The customer has now been deleted
    </p>
    <p>
        <asp:Button ID="btnbacktocustomerpage" runat="server" Height="45px" OnClick="btnbacktocustomerpage_Click" Text="back to customer homepage" Width="206px" />
    </p>
</asp:Content>

