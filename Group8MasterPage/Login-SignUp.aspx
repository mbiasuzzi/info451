<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login-SignUp.aspx.cs" Inherits="Group8MasterPage.Login_SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="UsernameTxt" runat="server">Username</asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="PasswordTxt" runat="server">Password</asp:TextBox>
    <br />
    <br />
    <asp:Button ID="lgnbtn" runat="server" Text="Login" OnClick="lgnbtn_Click"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="sgnupbtn" runat="server" Text="Sign Up" OnClick="sgnupbtn_Click"/>
</asp:Content>
