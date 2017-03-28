<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="HekimRandevulari.aspx.cs" Inherits="Ornek.HekimRandevulari" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
   
</asp:Content> 


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
        
 </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
      <asp:GridView ID="grid_HekimRandevu" runat="server">
    </asp:GridView>
     </asp:Content>
