<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="SifremiUnuttum.aspx.cs" Inherits="Ornek.SifremiUnuttum" %>
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
    <asp:label ID="lblEmail" for="txtEmail" runat="server" >E-Mail Adresiniz:</asp:label>
        <br />
        <asp:Textbox ID="txtEmail" runat="server" Width="288px"></asp:Textbox>
        <br />
        <br />
                        
        <asp:Button ID="btnGonder" runat="server" Text="Gönder" Width="106px" OnClick="btnGonder_Click" style="height: 26px" />
        <br />
        <br />
        <asp:Label ID="lblMesaj" runat="server" ></asp:Label>

    </asp:Content>