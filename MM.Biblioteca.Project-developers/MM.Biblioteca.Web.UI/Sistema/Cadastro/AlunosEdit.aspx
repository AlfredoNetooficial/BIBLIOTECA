<%@ Page Title="" Language="C#" MasterPageFile="~/Sistema/PageMain.Master" AutoEventWireup="true" CodeBehind="AlunosEdit.aspx.cs" Inherits="MM.Biblioteca.Web.UI.Sistema.AlunosEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class=" mb-4">Editar Aluno</h1>
    <div style="margin-bottom: 3%">
        <div class=" card ">
            <div class="card-header small"><i class="fa-solid fa-table mr-1"></i>EDITAR DADOS</div>
            <div class="card-body">

                <div class=" form-row">
                    <div class="form-group col">
                        <asp:CheckBox ID="cbAtivo" runat="server" Text=" Aluno Ativo" Checked="true" />
                    </div>

                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label>Nome</label>
                        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" MaxLength="300" />
                    </div>
                    <div class="form-group col-md-6">
                        <label>Telefone</label>
                        <asp:TextBox ID="txtTelefone" runat="server" CssClass="form-control" MaxLength="300" TextMode="Phone" />
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label>CPF</label>
                        <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control" MaxLength="300" />
                    </div>
                    <div class="form-group col-md-6">
                        <label>Rua</label>
                        <asp:TextBox ID="txtRua" runat="server" CssClass="form-control" MaxLength="300" />
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-4">
                        <label>Bairro</label>
                        <asp:TextBox ID="txtBairro" runat="server" CssClass="form-control" MaxLength="300" />
                    </div>

                    <div class="form-group col-md-4">
                        <label>Cidade</label>
                        <asp:TextBox ID="txtCidade" runat="server" CssClass="form-control" MaxLength="300" />
                    </div>
                    <div class="form-group col-md-4">
                        <label>UF</label>
                        <asp:TextBox ID="txtUF" runat="server" CssClass="form-control" MaxLength="300" />
                    </div>
                </div>

                <div class=" form-row">
                    <div class="form-group col-md-12">
                        <label>Nº Matricula</label>
                        <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control" MaxLength="300" />
                    </div>
                </div>

                <div class="form-row" style="margin-top: 3%">
                    <div class="form-group col-md-6">
                        <asp:Button ID="btnSalvar" runat="server" CssClass="btn btn-primary" Text="Salvar" OnClick="btnSalvar_Click"/>
                        <a class="btn btn-outline-secondary" href="AlunosList.aspx">Voltar</a>
                    </div>
                </div>
            </div>
        </div>

    </div>

</asp:Content>
