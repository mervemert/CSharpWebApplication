<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/masterPage.Master" CodeBehind="AdminForm.aspx.cs" Inherits="Ornek.AdminForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
   Admin Form
</asp:Content> 


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    
 </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">TC :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txttc" runat="server" AutoCompleteType="None"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Şifre :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtsifre" runat="server" AutoCompleteType="None"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Adı :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtad" runat="server" AutoCompleteType="None"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Soyadı : </td>
            <td class="auto-style3">
                <asp:TextBox ID="txtsoyad" runat="server" AutoCompleteType="None"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Cinsiyet :</td>
            <td class="auto-style3">
             <asp:TextBox ID="txtcins" runat="server" AutoCompleteType="None"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Dogum Yeri :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtdyer" runat="server" AutoCompleteType="None"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Telefon :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txttel" runat="server" AutoCompleteType="None"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">E-mail :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtmail" runat="server" AutoCompleteType="None"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Dogum Tarihi :</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtdtarih" runat="server" AutoCompleteType="None"></asp:TextBox>
            </td>
        </tr>
    </table>

    <br /><br />

    <asp:Button ID="btnlistele" runat="server" Text="LİSTELE" OnClick="btnlistele_Click" />
    <asp:Button ID="btnekle" runat="server" Text="EKLE" OnClick="btnekle_Click" />
    <asp:Button ID="btnguncelle" runat="server" Text="GÜNCELLE" OnClick="btnguncelle_Click" />
    <asp:Button ID="btnsil" runat="server" Text="SİL" OnClick="btnsil_Click" />
    <br /><br />

    <asp:GridView ID="gridcrud" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="TcNo" HeaderText="TC Kimlik" />
            <asp:BoundField DataField="Sifre" HeaderText="Şifre" />
            <asp:BoundField DataField="Adi" HeaderText="Adı" />
            <asp:BoundField DataField="Soyadi" HeaderText="Soyadı" />
            <asp:BoundField DataField="Cinsiyet" HeaderText="Cinsiyet" />
            <asp:BoundField DataField="DogumYeri" HeaderText="Doğum Yeri" />
            <asp:BoundField DataField="Tel" HeaderText="Telefon" />
            <asp:BoundField DataField="Email" HeaderText="E-mail" />
            <asp:BoundField DataField="DogumTarihi" HeaderText="Dogum Tarihi" />

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lnksec" runat="server" CommandArgument='<%# Eval("UyeID") %>' OnClick="linkSec_Click">Seç</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>
        </asp:Content>