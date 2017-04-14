<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp-Page.aspx.cs" Inherits="Group8MasterPage.SignUp_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="Username" runat="server">Username</asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="Password" runat="server" BorderColor="Black" ForeColor="Black">Password</asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="Email" runat="server">Email </asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="Phone" runat="server">Phone Number</asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="Sign Up" />
</asp:Content>
