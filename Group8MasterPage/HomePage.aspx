<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Group8MasterPage.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:Repeater ID="Repeater1" runat="server" EnableViewState="false" OnItemCommand="Repeater1_ItemCommand">
       <ItemTemplate>
           <div style="border:2px #808080; padding:10px; margin:10px;">
               <div class="picture push-xl9">
                   <asp:Image ID="imgPicture" runat="server" ImageUrl='<%# Eval("Picture") %>' />
               </div>
                <div class="col-xs-9">
                <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("Title_of_Book") %>' />
                    <br />
                    <p>ISBN:
                <asp:Label ID="lblIsbn" runat="server" Text='<%# Eval("ISBN") %>' /></p>
                    <p>Description:</p>
                <asp:Label ID="lblDescription" runat="server" Text='<%# Eval("Description") %>' /> 
                    <br />              
                <asp:LinkButton ID="btnMoreInfo" runat="server" Text="More Info" CommandArgument='<%# Eval("BookID") %>'></asp:LinkButton>

                    </div>
           </div>
       </ItemTemplate>
       <SeparatorTemplate>
           <hr />
       </SeparatorTemplate>
       </asp:Repeater>
</asp:Content>
