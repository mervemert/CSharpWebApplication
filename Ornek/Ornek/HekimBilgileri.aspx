<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="HekimBilgileri.aspx.cs" Inherits="Ornek.HekimBilgileri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
   Category
</asp:Content> 


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            background-color: #FFFFFF;
        }
    </style>
    
 </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    
    <asp:Button ID="btn_RandevuGor" runat="server" Text="Randevuları Gör" OnClick="btn_RandevuGor_Click" Width="171px" />
    <br /><br />
    <asp:Button ID="btn_HastaBilgileri" runat="server" Text="Hasta Bilgilerini Gör" />
    </asp:Content>