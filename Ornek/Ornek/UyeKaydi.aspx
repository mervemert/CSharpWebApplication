<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="UyeKaydi.aspx.cs" Inherits="Ornek.UyeKaydi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
   Category
</asp:Content> 


<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    
 </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
     <table class="uye_tablo">
            <caption>
                <h3 style="text-align:left; color:cadetblue">ÜYE KAYIT SAYFASI</h3> </caption>
            <tr>
                <td class="label">TC Kimlik No :</td>
                <td class="textbox">
                    <asp:TextBox ID="txt_tc" runat="server"  AutoCompleteType="None"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="label">Şifre :</td>
                <td class="textbox">
                    <asp:TextBox ID="txt_sifre" MaxLength="11" runat="server" AutoPostBack="false"></asp:TextBox>
                </td>
            </tr>
           
            <tr>
                <td class="label">Adı :</td>
                <td class="auto-style25">
                    <asp:TextBox ID="txt_adi" runat="server" AutoCompleteType="None"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="label">Soyadı :</td>
                <td class="auto-style27">
                    <asp:TextBox ID="txt_soyadi" runat="server" AutoCompleteType="None"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="label">Cinsiyet :</td>
                <td class="auto-style3">
                    <asp:RadioButtonList ID="rblist_cins" runat="server">
                        <asp:ListItem Selected="True">Erkek</asp:ListItem>
                        <asp:ListItem>Kadın</asp:ListItem>
                    </asp:RadioButtonList>
                   
                </td>
            </tr>
            <tr>
                <td class="label">Doğum Yeri :</td>
                <td class="auto-style4">
                

                    <asp:TextBox ID="txt_dYeri" runat="server" AutoCompleteType="None"></asp:TextBox>
                

                </td>
            </tr>
            <tr>
                <td class="label">Doğum Tarihi : </td>
                <td class="auto-style14">
                    <asp:TextBox ID="txt_dTarihi" runat="server" AutoCompleteType="None"></asp:TextBox>
                    </td>
               
            </tr>
            <tr>
                <td class="label">Telefon :</td>
                <td class="auto-style32">
                    <asp:TextBox ID="txt_tel" runat="server" AutoCompleteType="None"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="label">E-mail :</td>
                <td class="auto-style38">
                    <asp:TextBox ID="txt_mail" runat="server" AutoCompleteType="None"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style36">
                    <asp:Button ID="txt_kaydet" runat="server" Text="KAYDET" Width="129px" OnClick="txt_kaydet_Click" Height="30px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
        </table>
    
        </asp:Content>