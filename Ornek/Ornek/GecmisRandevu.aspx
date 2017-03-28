<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="GecmisRandevu.aspx.cs" Inherits="Ornek.GecmisRandevu" %>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
   Category
</asp:Content> 


<asp:Content ID="Content4" ContentPlaceHolderID="head" runat="server">
    
 </asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="contentBody" runat="server">
     <asp:GridView ID="gridGecmisRandevu" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Hekim" DataField="Hekim" />
            <asp:BoundField HeaderText="Randevu Zamanı" DataField="Saat" />
            <asp:BoundField HeaderText="Kurum Adi" DataField="Hastane" />
            <asp:BoundField HeaderText="Klinik Adi" DataField="Klinik" />
            <asp:BoundField HeaderText="KlinikYeri" DataField="KlinikYeri" />

        </Columns> 

     </asp:GridView>

    <asp:Button ID="geriDon" Text="Geri Dön" runat="server" OnClick="geriDon_Click" />
        </asp:Content>



