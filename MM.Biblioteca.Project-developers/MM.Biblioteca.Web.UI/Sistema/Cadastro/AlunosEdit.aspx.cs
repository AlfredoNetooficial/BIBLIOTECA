using MM.Biblioteca.Core.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MM.Biblioteca.Web.UI.Sistema
{
    public partial class AlunosEdit : System.Web.UI.Page
    {
        int IDALUNO
        {
            get
            {
                return Convert.ToInt32(Request.QueryString["ID"]);
            }
        }
        #region methodo
        void LoadData()
        {
            var Aluno = BizAluno.GetAluno(IDALUNO);

            cbAtivo.Checked = Aluno.SITUACAO.Equals(Aluno.SITUACAO);
            txtNome.Text = Aluno.NOME;
            txtTelefone.Text = Aluno.TELEFONE;
            txtCPF.Text = Aluno.CPF;
            txtRua.Text = Aluno.RUA;
            txtBairro.Text = Aluno.BAIRRO;
            txtCidade.Text = Aluno.CIDADE;
            txtUF.Text = Aluno.UF;
            txtMatricula.Text = Aluno.MATRICULA;
        }

        bool Validations()
        {
            //TODO 
            // Fazer a validação de campos como por exemplo CPF, Nome, Telefone, Matricula

            return true;
        }

        void Save()
        {
            try
            {
                if (Request.QueryString["ID"] == null)
                {
                    BizAluno.Insert(txtNome.Text, txtTelefone.Text, txtCPF.Text,
                        txtRua.Text, txtBairro.Text, txtCidade.Text, txtUF.Text, txtMatricula.Text, cbAtivo.Checked);
                }
                else
                {
                    BizAluno.Update(IDALUNO, txtNome.Text, txtTelefone.Text, txtCPF.Text, txtRua.Text, txtBairro.Text, txtCidade.Text, txtUF.Text, cbAtivo.Checked, txtMatricula.Text);
                }
                   
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Desculpe, algo deu errado');</script>");
                Console.WriteLine(ex.Message);
               
            }

            Response.Redirect("AlunosList.aspx");
        }
        #endregion
        #region Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    LoadData();
                }
            }
        }
        

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validations())
                {
                    Save();
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Desculpe, algo deu errado');</script>");
                Console.Write(ex.Message);
            }
            
            
        }

        #endregion
    }
}