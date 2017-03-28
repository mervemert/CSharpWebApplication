<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="RandevuGuncelle.aspx.cs" Inherits="Ornek.RandevuGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
   Category
</asp:Content> 


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    
 </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <asp:Button ID="randevu_guncelle" Text="Güncelle" runat="server" OnClick="randevu_guncelle_Click" />
            </asp:Content>