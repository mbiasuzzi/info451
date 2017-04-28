<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Group8MasterPage.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:Repeater ID="Repeater1" runat="server" EnableViewState="false" OnItemCommand="Repeater1_ItemCommand">
       <ItemTemplate>
           <div class="row">
           <div class="col-md-12" style="border:2px #808080; padding:10px; margin:10px;">
               <div class="picture col-md-2">
                   <asp:Image class="img-responsive imgsize" ID="imgPicture" runat="server" ImageUrl='<%# Eval("Picture") %>' />
               </div>
                <div class="col-md-10">
                <div class="lblDetail"><asp:Label ID="lblTitle" runat="server" Text='<%# Eval("Title_of_Book") %>' /></div>
                    <br />
                    <div class="lblDetail">ISBN: </div>
                <asp:Label ID="lblIsbn" runat="server" Text='<%# Eval("ISBN") %>' /></p>
                    <div class="lblDetail"> Description: </div>
                <asp:Label ID="lblDescription" runat="server" Text='<%# Eval("Description") %>' /> 
                    <br />              
                <asp:LinkButton ID="btnMoreInfo" runat="server" Text="More Info" CommandArgument='<%# Eval("BookID") %>'></asp:LinkButton>

                    </div>
           </div>
          </div>
       </ItemTemplate>
       <SeparatorTemplate>
           <hr />
       </SeparatorTemplate>
       </asp:Repeater>
</asp:Content>
