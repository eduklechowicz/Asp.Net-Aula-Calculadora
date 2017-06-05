<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarProprietario.aspx.cs" Inherits="Imobiliaria.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %> Editar</h2>
 
      <asp:UpdatePanel ID="upCampos" runat="server">
        <ContentTemplate>
        <div class="jumbotron">

            <div class="row">
                <asp:Label ID="lblNome" runat="server" Text="Nome Do Proprietario: "></asp:Label><br>
                <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNome" runat="server" ErrorMessage="Campo Nome Obrigatório" ControlToValidate="txtNome"></asp:RequiredFieldValidator>
                <asp:Button ID="btnProcurar" runat="server" Text="Buscar" OnClick="btnProcurar_Click" />
                 </div>

             <div class="row">
                <asp:Label ID="lblTelefone" runat="server" Text="Telefone: "></asp:Label><br>
                <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Telefone Obrigatório" ControlToValidate="txtTelefone"></asp:RequiredFieldValidator>
            </div>
             <div class="row">
                <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label><br>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Email Obrigatório" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
            </div>
             <div class="row">
                <asp:Label ID="lblCLiente" runat="server" Text="Id Do Cliente: "></asp:Label><br>
                <asp:TextBox ID="txtIdCliente" runat="server"></asp:TextBox>
            </div>
             <div class="row">
                <asp:Label ID="lblAtivo" runat="server" Text="Ativo: "></asp:Label><br>
                 <asp:CheckBox ID="chkAtivo" runat="server" />

             </div>
            <div class="row">
                <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" />
                <asp:Button ID="btnDeletar" runat="server" Text="Deletar" OnClick="btnDeletar_Click" />
            </div>
        </div>
        </ContentTemplate>
       </asp:UpdatePanel>
</asp:Content>
