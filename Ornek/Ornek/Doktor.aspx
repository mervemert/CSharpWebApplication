<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Doktor.aspx.cs" Inherits="Ornek.Doktor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
   Doktor
</asp:Content> 


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    
 </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
<table class="auto-style1">
        <tr>
            <td class="auto-style2">TC Kimlik No : </td>
            <td>
                <asp:TextBox ID="txt_tcHekim" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Şifre :</td>
            <td>
                <asp:TextBox ID="txt_sifreHekim" TextMode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:Button ID="btn_girisHekim" runat="server" Text="Giriş" Width="86px" OnClick="btn_girisHekim_Click"  />
        </asp:Content>