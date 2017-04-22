<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MyProfile.aspx.cs" Inherits="Group8MasterPage.MyProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>MyProfile</p>
    <asp:Label ID="Label1" runat="server" Text="Add a listing"></asp:Label>
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Addbtn" runat="server" OnClick="Addbtn_Click" Text="Add" />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Delete a listing"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Delbtn" runat="server" OnClick="Delbtn_Click" Text="Delete" />
    
</asp:Content>
