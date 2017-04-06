<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="BookDetails.aspx.cs" Inherits="Group8MasterPage.BookDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="BookDetails" style="border:2px #808080; padding:10px; margin:10px;">
                    <div class="detail_pic">
                        <asp:Image ID="Image1" runat="server"/>
                    </div>
                    <div class="featured_desc">
                        Title:<asp:Label ID="TitleBook" CssClass="featuredBookTitle" runat="server" Text="Label"></asp:Label>
                         <br />
                    <div class="book_details" >
                        Description:<asp:Label ID="DescBook" CssClass="featuredBookDesc" runat="server"></asp:Label>
                        <br />
                        Isbn:<asp:Label ID="Isbn" runat="server"></asp:Label>
                         <br />
                        Author:<asp:Label ID="Author" runat="server"></asp:Label>
                         <br />
                        Version:<asp:Label ID="BookVersion" runat="server"></asp:Label> 
                         <br />     
                        Condition:<asp:Label ID="Condition" runat="server"></asp:Label>
                         <br />
                        Price<asp:Label ID="Price" CssClass="featuredBookDesc" runat="server"></asp:Label>
                         <br />
                        <asp:Button ID="BuyBtn" runat="server" Text="Buy" OnClick="BuyBtn_Click" />
                     </div>
                    </div>
                </div>
</asp:Content>
