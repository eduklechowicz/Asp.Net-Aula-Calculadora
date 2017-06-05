<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarCliente.aspx.cs" Inherits="Imobiliaria.Views.Clientes.EditarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:UpdatePanel ID="upCamposCliente" runat="server">
        <ContentTemplate>
        <div class="jumbotron">

            <div class="row">
                <asp:Label ID="lblNomeCliente" runat="server" Text="Nome Do Cliente: "></asp:Label><br>
                <asp:DropDownList ID="ddlCliente" runat="server" AutoPostBack="True" OnLoad="ddlCliente_Load" OnSelectedIndexChanged="ddlCliente_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Nome Obrigatório" ControlToValidate="ddlCliente"></asp:RequiredFieldValidator>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                
                 </div>

             <div class="row">
                <asp:Label ID="lblEndereco" runat="server" Text="Endereço: "></asp:Label><br>
                <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Endereco Obrigatório" ControlToValidate="txtEndereco"></asp:RequiredFieldValidator>
            </div>
             <div class="row">
                <asp:Label ID="lblPreco" runat="server" Text="Preço: "></asp:Label><br>
                <asp:TextBox ID="txtPreco" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo Preco Obrigatório" ControlToValidate="txtPreco"></asp:RequiredFieldValidator>
            </div>
            <div class="row">
                <asp:Label ID="lblDescricao" runat="server" Text="Descrição: "></asp:Label><br>
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
             <div class="row">
                <asp:Label ID="lblAtivoCliente" runat="server" Text="Ativo: "></asp:Label><br>
                 <asp:CheckBox ID="chkAtivoCliente" runat="server" />

             </div>
            <div class="row">
                <asp:Button ID="btnEditarCliente" runat="server" Text="Editar" OnClick="btnEditarCliente_Click"/>
                <asp:Button ID="btnDeletarCliente" runat="server" Text="Deletar" OnClick="btnDeletarCliente_Click" />
            </div>
        </div>
        </ContentTemplate>
       </asp:UpdatePanel>
</asp:Content>
