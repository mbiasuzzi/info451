<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="Group8MasterPage.BookDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="BookDetails" style="border:2px #808080; padding:10px; margin:10px;">
                    <div class="detail_pic">
                        <asp:Image  class="img-responsive" ID="Image1" runat="server"/>
                    </div>
                    <div class="featured_desc">
                        <div class="lblDetail">Title: </div><asp:Label ID="TitleBook" CssClass="featuredBookTitle" runat="server" Text="Label"></asp:Label>
                         <br />
                    <div class="book_details" >
                        <div class="lblDetail">Description: </div><asp:Label ID="DescBook" CssClass="featuredBookDesc" runat="server"></asp:Label>
                        <br />
                        <div class="lblDetail">Isbn: </div><asp:Label ID="Isbn" runat="server"></asp:Label>
                         <br />
                        <div class="lblDetail">Author: </div><asp:Label ID="Author" runat="server"></asp:Label>
                         <br />
                        <div class="lblDetail">Version: </div><asp:Label ID="BookVersion" runat="server"></asp:Label> 
                         <br />     
                        <div class="lblDetail">Condition: </div><asp:Label ID="Condition" runat="server"></asp:Label>
                         <br />
                        <div class="lblDetail">Price: </div><asp:Label ID="Price" CssClass="featuredBookDesc" runat="server"></asp:Label>
                         <br />
                        <asp:Button class="btn-lg" ID="BuyBtn" runat="server" Text="Buy" OnClick="BuyBtn_Click" />
                     </div>
                    </div>

                </div>
</asp:Content>
