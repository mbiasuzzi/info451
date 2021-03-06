﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="Group8MasterPage.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView runat="server" ID="ShoppingCartGrid" AutoGenerateDeleteButton="True" CssClass="shoppingcart" OnRowDeleting="ShoppingCartGrid_RowDeleting"></asp:GridView>
    <div class="total">
        <asp:Label ID="lblTotal" runat="server" Text="Total Price: $"></asp:Label>
        <asp:Label ID="numberTotal" runat="server" Text=""></asp:Label>
        <br />
     </div>
    <div class="message">
        <asp:Label ID="lblNewEmail"  runat="server" Text="To complete your purchase please enter an email or log in."></asp:Label>
        <asp:TextBox ID="txtNewEmail"  runat="server"></asp:TextBox>
        <asp:Button ID="btnNewEmail"  runat="server" Text="Submit" OnClick="btnNewEmail_Click" />
        <asp:Button class="btn-lg" ID="btnPurchase" runat="server" Text="Purchase" OnClick ="btnPurchase_Click" />
    </div>
   
</asp:Content>
    