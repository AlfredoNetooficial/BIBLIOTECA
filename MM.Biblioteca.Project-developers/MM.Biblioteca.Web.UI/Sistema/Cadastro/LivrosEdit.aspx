<%@ Page Title="" Language="C#" MasterPageFile="~/Sistema/PageMain.Master" AutoEventWireup="true" CodeBehind="LivrosEdit.aspx.cs" Inherits="MM.Biblioteca.Web.UI.Sistema.Cadastro.LivrosEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h1 class=" mb-4">Editar Livro</h1>
    <div style="margin-bottom: 3%">
        <div class=" card ">
            <div class="card-header small"><i class="fa-solid fa-table mr-1"></i>EDITAR DADOS</div>
            <div class="card-body">

                <div class=" form-row">
                    <div class="form-group col">
                        <asp:CheckBox ID="cbDisponivel" runat="server" Text=" Livro Disponivel" Checked="true" />
                    </div>

                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label>Editora</label>
                        <asp:DropDownList ID="ddlEditora" runat="server" CssClass="form-control" MaxLength="300" />
                    </div>
                    <div class="form-group col-md-6">
                        <label>Nome</label>
                        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" MaxLength="300" />
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label>Assunto</label>
                        <asp:TextBox ID="txtAssunto" runat="server" CssClass="form-control" MaxLength="300" />
                    </div>
                    <div class="form-group col-md-6">
                        <label>Autor</label>
                        <asp:TextBox ID="txtAutor" runat="server" CssClass="form-control" MaxLength="300" />
                    </div>
                </div>

                <div class="form-row" style="margin-top: 3%">
                    <div class="form-group col-md-6">
                        <asp:Button ID="btnSalvar" runat="server" CssClass="btn btn-primary" Text="Salvar" OnClick="btnSalvar_Click"/>
                        <a class="btn btn-outline-secondary" href="LivrosList.aspx">Voltar</a>
                    </div>
                </div>
            </div>
        </div>

    </div>

</asp:Content>
