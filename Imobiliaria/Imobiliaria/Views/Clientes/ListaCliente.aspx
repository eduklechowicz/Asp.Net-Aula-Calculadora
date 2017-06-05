<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaCliente.aspx.cs" Inherits="Imobiliaria.Views.Cliente.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:UpdatePanel ID="upCampos" runat="server">
        <ContentTemplate>
        <div class="jumbotron">

            <div class="row">
                <asp:Label ID="lblNome" runat="server" Text="Nome Do Cliente: "></asp:Label><br>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNome" runat="server" ErrorMessage="Campo Nome Obrigatório" ControlToValidate="txtNome"></asp:RequiredFieldValidator>
            </div>

             <div class="row">
                <asp:Label ID="lblEndereco" runat="server" Text="Endereço: "></asp:Label><br>
                <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Endereco Obrigatório" ControlToValidate="txtEndereco"></asp:RequiredFieldValidator>
            </div>
             <div class="row">
                <asp:Label ID="lblPreco" runat="server" Text="Preço: "></asp:Label><br>
                <asp:TextBox ID="txtPreco" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Preco Obrigatório" ControlToValidate="txtPreco"></asp:RequiredFieldValidator>
            </div>
            <div class="row">
                <asp:Label ID="lblDescricao" runat="server" Text="Descrição: "></asp:Label><br>
                <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
             <div class="row">
                <asp:Label ID="lblAtivo" runat="server" Text="Ativo: "></asp:Label><br>
                 <asp:CheckBox ID="chkAtivo" runat="server" />

             </div>
            <div class="row">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" CausesValidation="false" />
            </div>
        </div>

            <div class="row">
                <asp:GridView ID="gvTudo" runat="server"></asp:GridView>
            </div>

        </ContentTemplate>
       </asp:UpdatePanel>
</asp:Content>
