<%@ Page Title="" Language="C#" MasterPageFile="~/Sistema/PageMain.Master" AutoEventWireup="true" CodeBehind="LivrosList.aspx.cs" Inherits="MM.Biblioteca.Web.UI.Sistema.Cadastro.LivrosList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="m-3">Livros</h1>
    <a href="LivrosEdit.aspx" class=" btn btn-primary btn-lg mb-3">

        <i class="fa-solid fa-circle-plus"></i>
        Adicionar Novo
    </a>

    <div class=" card">
        <div class="card-header small"><i class="fa-solid fa-table mr-1"></i>LIVROS CADASTRADOS</div>
        <div class="card-body">
            <asp:GridView ID="gvDados" runat="server" DataKeyNames="IDLIVRO" CssClass="table table-striped"
                 AllowPaging="true" PageSize="30" OnPageIndexChanging="gvDados_PageIndexChanging"
                AutoGenerateColumns="false" GridLines="None" OnSelectedIndexChanged="gvDados_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField HeaderText="NOME">
                        <ItemTemplate>
                            <a href="<%# "LivrosEdit.aspx?id=" + Eval("IDLIVRO") %>">
                                <%# Eval("NOME") %>

                            </a>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="IDEDITORA" HeaderText="EDITORA"/>
                    <asp:BoundField DataField="ASSUNTO" HeaderText="ASSUNTO"/>
                    <asp:BoundField DataField="AUTOR" HeaderText="AUTOR"/>
                    <asp:BoundField DataField="STATUS" HeaderText="DISPONIVEL"/>


                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton runat="server" CssClass="btn btn-outline-secondary btn-sm" CommandName="select"
                                ToolTip="Excluir Aluno" OnClientClick="return confirm('Confirma Exclusão do aluno?')">

                                <i class="fa-solid fa-trash"></i>

                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
        <div class="card-footer small text-right">
            <i class="fa-solid fa-list-ul"></i>
            EXIBINDO
            <asp:Label ID="lblCount" runat="server"></asp:Label>
        </div>

    </div>

</asp:Content>
