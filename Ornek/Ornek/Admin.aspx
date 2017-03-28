<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Ornek.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
  Admin
</asp:Content> 


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    
 </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table class="auto-style1">
       
        <tr>
            <td class="auto-style2">Şifre :</td>
            <td>
                <asp:TextBox ID="txt_sifreAdmin" TextMode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btn_girisAdmin" runat="server" Text="Giriş" Width="86px" OnClick="btn_girisAdmin_Click"   />
        </asp:Content>