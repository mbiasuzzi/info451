<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PaymentInfo-Page.aspx.cs" Inherits="Group8MasterPage.PaymentInfo_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server" Width="282px">Cardholder Name</asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="177px">Card Number</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" Width="61px">CVC</asp:TextBox>
    <br />
    <br />
    <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged">Expiration Date</asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
</asp:Content>
