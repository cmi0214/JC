<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="Test.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="float:right;">
        <asp:Button ID="Bt_Dashboard" runat="server" Text="Go to Dashboard" OnClick="Bt_Dashboard_Click" />
    </div>
    

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
       <asp:ListView ID="Lb_ProductDetail" runat="server" OnItemDataBound="Lb_ProductDetail_ItemDataBound" >
        <LayoutTemplate>
            
            <table style="width: 100%;" class="table-bordered">
                <tr>
                    <td>No.</td>
                    <td>Title</td>
                    <td>Description</td>
                  
                </tr>
                   <asp:PlaceHolder runat="server" ID="itemPlaceholder"></asp:PlaceHolder>

            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:Label ID="Lb_No" runat="server" Text='<%#Eval("No") %>'></asp:Label>
                </td>

                <td >
                    <asp:Label ID="Lb_Title" runat="server" Text='<%#Eval("Title") %>' >></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Lb_Description" runat="server" Text='<%#Eval("Description") %>'></asp:Label>
                </td>
            
            </tr>

        </ItemTemplate>

    </asp:ListView>


</asp:Content>
