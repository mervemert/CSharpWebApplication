<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UyeKayit.aspx.cs" Inherits="Ornek.UyeKayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 99%;
            height: 533px;
        }
        .auto-style2 {
            width: 120px;
        }
        .auto-style3 {
            width: 120px;
            height: 31px;
        }
        .auto-style4 {
            height: 31px;
            width: 547px;
        }
        .auto-style5 {
            width: 120px;
            height: 29px;
        }
        .auto-style6 {
            height: 29px;
            width: 547px;
        }
        .auto-style7 {
            width: 547px;
        }
        .auto-style8 {
            width: 120px;
            height: 69px;
        }
        .auto-style9 {
            width: 547px;
            height: 69px;
        }
        .auto-style10 {
            width: 120px;
            height: 278px;
        }
        .auto-style11 {
            width: 547px;
            height: 278px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <table class="auto-style1">
            <caption>
                ÜYE KAYIT SAYFASI</caption>
            <tr>
                <td class="auto-style2">TC Kimlik No :</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txt_tc" runat="server" AutoPostBack="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Şifre :</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txt_sifre" runat="server" AutoPostBack="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Adı :</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txt_adi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Soyadı :</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txt_soyadi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Cinsiyet :</td>
                <td class="auto-style9">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Selected="True">Erkek</asp:ListItem>
                        <asp:ListItem>Kadın</asp:ListItem>
                    </asp:RadioButtonList>
                   
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Doğum Yeri :</td>
                <td class="auto-style4">
                

                    <asp:TextBox ID="txt_dYeri" runat="server"></asp:TextBox>
                

                </td>
            </tr>
            <tr>
                <td class="auto-style10">Doğum Tarihi :</td>
                <td class="auto-style11">
                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Height="52px" Width="269px"></asp:Calendar>
                    <asp:Label ID="lbl_tarih" runat="server"  ForeColor="#660033" ></asp:Label>
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Telefon :</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txt_tel" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">E-mail :</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txt_mail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="txt_kaydet" runat="server" Text="KAYDET" Width="178px" OnClick="txt_kaydet_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
