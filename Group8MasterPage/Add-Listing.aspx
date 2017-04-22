<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Add-Listing.aspx.cs" Inherits="Group8MasterPage.Add_Listing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="tittxt" runat="server">Title of Book</asp:TextBox>
    <br />
    <asp:TextBox ID="desctxt" runat="server">Description</asp:TextBox>
    <br />
    <asp:TextBox ID="isbn" runat="server">ISBN</asp:TextBox>
    <br />
    <asp:TextBox ID="authtxt" runat="server">Author</asp:TextBox>
    <br />
    <asp:TextBox ID="vertxt" runat="server">Version</asp:TextBox>
    <br />
    <asp:TextBox ID="contxt" runat="server">Condition</asp:TextBox>
    <br />
    <asp:TextBox ID="prctxt" runat="server">Price</asp:TextBox>
    <br />
    <asp:TextBox ID="qtytxt" runat="server">Quantity</asp:TextBox>
    <br />
    <br />
    <asp:Button ID="subbtn" runat="server" OnClick="subbtn_Click" Text="Add" />
    <br />
</asp:Content>
