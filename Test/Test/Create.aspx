<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Test.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td> Title </td> 
            <td> <asp:TextBox ID="tb_CreateTitle" runat="server"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td> Description </td>
            <td> <asp:TextBox ID="tb_CreateDescription" TextMode="MultiLine" runat="server" style="width:100%; height:200px;"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td></td>
            <td><asp:Button ID="Bt_ok" runat="server" Text="Add" OnClick="Bt_ok_Click" /></td>
        </tr>
    </table>


</asp:Content>
