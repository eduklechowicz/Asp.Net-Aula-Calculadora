<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Aula1705.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    <asp:Label ID="lblQuantidadeCliques" runat="server" Text=""></asp:Label>
    <asp:Button ID="btnClique" runat="server" Text="Salvar" OnClick="btnClique_Click" />
    <asp:Button ID="btnEnviarCliques" runat="server" Text="Enviar" OnClick="btnEnviarCliques_Click" />
<br>
        <asp:TextBox ID="txtPrimario" runat="server"></asp:TextBox>
        <asp:Label ID="soma" runat="server" Text="+"></asp:Label>
        <asp:TextBox ID="txtSecundario" runat="server"></asp:TextBox>
        <asp:Label ID="igual" runat="server" Text="="></asp:Label>
        <asp:Label ID="total" runat="server" Text=""></asp:Label>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
