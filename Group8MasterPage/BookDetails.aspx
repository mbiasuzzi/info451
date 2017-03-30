<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="Group8MasterPage.BookDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="BookDetails">
                    <div class="detail_pic">
                        <asp:Image ID="Image1" runat="server"/>
                    </div>
                    <div class="featured_desc">
                        <asp:Label ID="TitleBook" CssClass="featuredBookTitle" runat="server" Text="Label"></asp:Label>
                         <br />
                    <div class="book_details" >
                        <asp:Label ID="DescBook" CssClass="featuredBookDesc" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="Isbn" runat="server"></asp:Label>
                         <br />
                        <asp:Label ID="Author" runat="server"></asp:Label>
                         <br />
                        <asp:Label ID="BookVersion" runat="server"></asp:Label> 
                         <br />     
                        <asp:Label ID="Condition" runat="server"></asp:Label>
                         <br />
                        <asp:Label ID="Price" CssClass="featuredBookDesc" runat="server"></asp:Label>
                         <br />
                        <asp:Button ID="BuyBtn" runat="server" Text="Buy" />
                     </div>
                    </div>
                </div>
</asp:Content>
