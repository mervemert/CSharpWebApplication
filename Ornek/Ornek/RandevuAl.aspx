<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="RandevuAl.aspx.cs" Inherits="Ornek.RandevuAl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
   Category
</asp:Content> 


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    
 </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <span style ="font-family:Arial">İlçe : </span>
<asp:DropDownList ID="ddlIlce" runat="server" AutoPostBack = "true" OnSelectedIndexChanged="ddlIlce_SelectedIndexChanged">
<asp:ListItem Text = "--İlçe Seç--" Value = ""></asp:ListItem>
</asp:DropDownList>
    
<br /><br />
<span style ="font-family:Arial">Hastane : </span>
<asp:DropDownList ID="ddlHastane" runat="server" AutoPostBack = "true"
Enabled = "false" OnSelectedIndexChanged="ddlHastane_SelectedIndexChanged">
<asp:ListItem Text = "--Hastane Seç--" Value = ""></asp:ListItem>
</asp:DropDownList>
 
<br /><br />
<span style ="font-family:Arial">Klinik : </span>
 <asp:DropDownList ID="ddlKlinik" runat="server" AutoPostBack = "true"
Enabled = "false" OnSelectedIndexChanged="ddlKlinik_SelectedIndexChanged">
<asp:ListItem Text = "--Hastane Seç--" Value = ""></asp:ListItem>
</asp:DropDownList>


    <br /><br />
    <span style="font-family:Arial">Klinik Yeri :</span>
    <asp:DropDownList ID="ddlKlinikYeri" runat="server" AutoPostBack="true" Enabled="false" OnSelectedIndexChanged="ddlKlinikYeri_SelectedIndexChanged">
        <asp:ListItem Text="---Klinik Yeri Seç---" Value=""></asp:ListItem>
    </asp:DropDownList>

    <br /><br />
    <span style="font-family:Arial">Hekim :</span>
    <asp:DropDownList ID="ddlHekim" runat="server" AutoPostBack="true" Enabled="false" OnSelectedIndexChanged="ddlHekim_SelectedIndexChanged">
        <asp:ListItem Text="---Hekim Seç---" Value=""></asp:ListItem>
    </asp:DropDownList>

    <br /><br />
    <asp:Button ID="btnRandevuAra" Text="Randevu Ara" runat="server" OnClick="btnRandevuAra_Click" />
    <br /><br />
    <asp:GridView ID="gridHekim" runat="server" AutoGenerateColumns="false" Width="313px" OnRowCommand="gridSaatGoster" >
        <Columns>
        <asp:BoundField HeaderText="Adı" DataField="HekimAdi" />
        <asp:BoundField HeaderText="Soyadı" DataField="HekimSoyadi" />
        <asp:BoundField HeaderText="En Erken Tarih" DataField="EnErkenTarih" />
        <asp:ButtonField HeaderText="Saat" ButtonType="Button" CommandName="SaatSec" Text="Saatleri Göster"   />
              
        </Columns>
        </asp:GridView>

       <asp:RadioButtonList ID="radioBtnList" RepeatDirection="Horizontal" runat="server" RepeatColumns="10" CellPadding="-1" CellSpacing="-1"></asp:RadioButtonList>
       <br /><br />
        <asp:Button ID="btnRandevuKaydet" runat="server" Text="Randevuyu Kaydet" OnClick="btnRandevuKaydet_Click" />
     
    
   
        </asp:Content>