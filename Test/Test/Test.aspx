<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Test.Test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <asp:Button ID="Bt_Create" runat="server" Text="Create" OnClick="Bt_Create_Click"/>
    
        <asp:Button ID="Bt_all" runat="server" Text="See All" OnClick="Bt_all_Click" />
   <div style="float:right;">
       <asp:TextBox ID="Tb_Search" runat="server"></asp:TextBox>
       <asp:Button ID="BtSearch" runat="server" Text="Button" OnClick="BtSearch_Click" />
   </div> 
    
    <asp:ListView ID="ListView1" runat="server" OnItemDataBound="ListView1_ItemDataBound" OnPagePropertiesChanged="ListView1_PagePropertiesChanged" >
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

                <td onclick='goDetail(<%#Eval("No") %>);'style="cursor:pointer;">
                    <asp:Label ID="Lb_Title" runat="server" Text='<%#Eval("Title") %>' >></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Lb_Description" runat="server" Text='<%#Eval("Description") %>'></asp:Label>
                </td>
            
            </tr>

        </ItemTemplate>



    </asp:ListView>
    <div style="float: left; margin-top: 20px;">
                <asp:DataPager runat="server" ID="ldPager" PagedControlID="ListView1" PageSize="5">
                <Fields>
                    <asp:NextPreviousPagerField 
                        ButtonType="Link"
                        ShowFirstPageButton="true"
                        ShowNextPageButton="false" 
                        ButtonCssClass="fg-button ui-state-default ui-corner-all" 
                        FirstPageText="<<" 
                        PreviousPageText="<"
                    />
                                    
                    <asp:NumericPagerField ButtonCount="20"
                        NumericButtonCssClass="fg-button ui-state-default ui-corner-all" 
                        CurrentPageLabelCssClass="curPaging fg-button ui-state-default ui-corner-all ui-widget-header ui-state-focus" 
                    />

                    <asp:NextPreviousPagerField 
                        ButtonType="Link"
                        ShowLastPageButton="true"
                        ShowNextPageButton="true"  
                        ShowPreviousPageButton="false"
                        ButtonCssClass="fg-button ui-state-default ui-corner-all" 
                        LastPageText=">>" 
                        NextPageText=">"
                    />
                </Fields>
                </asp:DataPager>
            </div>


  
      <script type="text/javascript">
          function goDetail(id) {
              window.location.href = "ProductDetail?id=" + id;
        }
    </script>


</asp:Content>
