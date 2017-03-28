<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="HastaBilgileri.aspx.cs" Inherits="Ornek.HastaBilgileri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
   Category
</asp:Content> 


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    
 </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
  <table>
    <td>
        <asp:Button ID="btnRandevuAl" runat="server" Text="Randevu Al" OnClick="btnRandevuAl_Click" />
    </td>
    <td>
        <asp:Button ID="btnRandevuGuncelle" runat="server" Text="Randevu Güncelle" OnClick="btnRandevuGuncelle_Click" />
    </td>
    <td>
        <asp:Button ID="btnGecmisRandevu" runat="server" Text="Geçmiş Randevular" OnClick="btnGecmisRandevu_Click" />
    </td>
    <td>
        <asp:Button ID="btnDoktorBilgileri" runat="server" Text="Doktor Bilgileri" OnClick="btnDoktorBilgileri_Click" />
    </td>
    <td>
        <asp:Button ID="btnHesapBilgileri" runat="server" Text="Hesap Bilgileri" OnClick="btnHesapBilgileri_Click" />
    </td>
    <td>
        <asp:Button ID="btnCikisYap" runat="server" Text="Çıkış Yap" OnClick="btnCikisYap_Click" />
    </td>
</table>
        </asp:Content>