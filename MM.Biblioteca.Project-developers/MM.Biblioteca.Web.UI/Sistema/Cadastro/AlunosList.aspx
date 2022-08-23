<%@ Page Title="" Language="C#" MasterPageFile="~/Sistema/PageMain.Master" AutoEventWireup="true" CodeBehind="AlunosList.aspx.cs" Inherits="MM.Biblioteca.Web.UI.Sistema.Alunos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="m-3">Alunos</h1>
    <a href="AlunosEdit.aspx" class=" btn btn-primary btn-lg mb-3">

        <i class="fa-solid fa-circle-plus"></i>
        Adicionar Novo
    </a> 

    <div class=" card">
        <div class="card-header small"><i class="fa-solid fa-table mr-1"></i>ALUNOS CADASTRADOS</div>
        <div class="card-body">
            <asp:GridView ID="gvDados" runat="server" DataKeyNames="IDALUNO" CssClass="table table-striped"
                 AllowPaging="true" PageSize="30" OnPageIndexChanging="gvDados_PageIndexChanging"
                AutoGenerateColumns="false" GridLines="None" OnSelectedIndexChanged="gvDados_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField HeaderText="Aluno">
                        <ItemTemplate>
                            <a href="<%# "AlunosEdit.aspx?id=" + Eval("IDALUNO") %>">
                                <%# Eval("Nome") %>

                            </a>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="CPF" HeaderText="CPF"/>

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
