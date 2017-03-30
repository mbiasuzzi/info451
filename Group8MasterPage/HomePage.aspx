<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Group8MasterPage.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="title_homepage">Featured Books</div>
            <div class="featured_books">
               <div class="Featured1">
                    <div class="feateured_pic">
                        <asp:Image ID="Image1" runat="server"/>
                    </div>
                    <div class="featured_desc">
                        <asp:Label ID="TitleBook1" CssClass="featuredBookTitle" runat="server" Text="Label"></asp:Label>
                         <br />
                        <asp:Label ID="DescBook1" CssClass="featuredBookDesc" runat="server"></asp:Label>
                         <br />
                        <asp:Button ID="MoreInfo1" runat="server" Text="More Info" OnClick="MoreInfo1_Click" />
                    </div>
                </div>
                <div class="Featured2">
                    <div class="feateured_pic">
                        <asp:Image ID="Image2" runat="server" />
                    </div>
                    <div class="featured_desc">
                        <asp:Label ID="TitleBook2" CssClass="featuredBookTitle" runat="server" Text="Label"></asp:Label>
                         <br />
                        <asp:Label ID="DescBook2" CssClass="featuredBookDesc" runat="server"></asp:Label>
                        <br />
                        <asp:Button ID="MoreInfo2" runat="server" Text="More Info" OnClick="MoreInfo1_Click" />
                    </div>
                </div>
                <div class="Featured3">
                   <div class="feateured_pic">
                        <asp:Image ID="Image3" runat="server" />
                    </div>
                    <div class="featured_desc">
                        <asp:Label ID="TitleBook3" CssClass="featuredBookTitle" runat="server" Text="Label"></asp:Label>
                         <br />
                        <asp:Label ID="DescBook3" CssClass="featuredBookDesc" runat="server"></asp:Label>
                        <br />
                        <asp:Button ID="MoreInfo3" runat="server" Text="More Info" OnClick="MoreInfo1_Click" />
                    </div>
                </div>
        </div>
    </div>
</asp:Content>
