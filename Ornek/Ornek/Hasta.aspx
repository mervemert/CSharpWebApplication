<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Hasta.aspx.cs" Inherits="Ornek.Hasta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
   Category
</asp:Content> 


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    
 </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">TC Kimlik No : </td>
            <td>
                <asp:TextBox ID="txt_tc" runat="server" AutoCompleteType="None"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Şifre :</td>
            <td>
                <asp:TextBox ID="txt_sifre" TextMode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>



 <asp:Button ID="btn_giris" runat="server" Text="Giriş" Width="86px" OnClick="btn_giris_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblgiris" runat="server"></asp:Label>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_uyeKayit" runat="server" Text="Yeni Üye" OnClick="btn_uyeKayit_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSifremiUnuttum" runat="server" Text="Şifremi Unuttum" OnClick="btnSifremiUnuttum_Click" />
        </asp:Content>