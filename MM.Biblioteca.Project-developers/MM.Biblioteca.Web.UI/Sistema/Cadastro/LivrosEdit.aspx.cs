using MM.Biblioteca.Core.Biz;
using MM.Biblioteca.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MM.Biblioteca.Web.UI.Sistema.Cadastro
{
    public partial class LivrosEdit : System.Web.UI.Page
    {
        int IDLIVRO
        {
            get
            {
                return Convert.ToInt32(Request.QueryString["ID"]);
            }
        }

        #region methodo
        void LoadData()
        {
            var Livro = BizLivro.GetLivro(IDLIVRO);
            
            cbDisponivel.Checked = (bool)Livro.STATUS;
            ddlEditora.SelectedValue = Livro.IDEDITORA.ToString();
            txtNome.Text = Livro.NOME;
            txtAssunto.Text = Livro.ASSUNTO;
            txtAutor.Text = Livro.AUTOR;

        }

        bool Validations()
        {
            //TODO 
            // Fazer a validação de campos como por exemplo CPF, Nome, Telefone, Matricula
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Response.Write("<script>alert('Preencha o campo Nome');</script>");
                return false;
            }

            if (string.IsNullOrEmpty(txtAssunto.Text))
            {
                Response.Write("<script>alert('Preencha o campo Assunto');</script>");
                return false;
            }

            if (string.IsNullOrEmpty(txtAutor.Text))
            {
                    Response.Write("<script>alert('Preencha o campo Autor');</script>");
                    return false;
            }
            return true;
        }

        void Save()
        {
            try
            {
                if (Request.QueryString["ID"] == null)
                {
                    BizLivro.Insert(Convert.ToInt32(ddlEditora.SelectedValue), txtNome.Text, txtAssunto.Text,
                        cbDisponivel.Checked, txtAssunto.Text);
                }
                else
                {
                    BizLivro.Update(IDLIVRO,Convert.ToInt32(ddlEditora.SelectedValue), txtNome.Text, txtAssunto.Text,
                        cbDisponivel.Checked, txtAssunto.Text);
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Desculpe, algo deu errado');</script>");
                Console.WriteLine(ex.Message);

            }

            Response.Redirect("LivroList.aspx");
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