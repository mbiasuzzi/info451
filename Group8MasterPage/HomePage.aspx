<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Group8MasterPage.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:Repeater ID="Repeater1" runat="server" EnableViewState="false" OnItemCommand="Repeater1_ItemCommand">
       <ItemTemplate>
           <div style="border:2px #808080; padding:10px; margin:10px;">
               <div class="picture col-md-4">
                   <asp:Image ID="imgPicture" runat="server" ImageUrl='<%# Eval("Picture") %>' />
               </div>
                <div class="col-md-8">
                <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("Title_of_Book") %>' />
                <asp:Label ID="lblIsbn" runat="server" Text='<%# Eval("ISBN") %>' />
                <asp:Label ID="lblDescription" runat="server" Text='<%# Eval("Description") %>' />               
                <asp:LinkButton ID="btnMoreInfo" runat="server" Text="More Info" CommandArgument='<%# Eval("BookID") %>'></asp:LinkButton>

                    </div>
           </div>
       </ItemTemplate>
       <SeparatorTemplate>
           <hr />
       </SeparatorTemplate>
       </asp:Repeater>
</asp:Content>
