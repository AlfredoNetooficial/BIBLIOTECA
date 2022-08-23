using MM.Biblioteca.Core.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MM.Biblioteca.Web.UI.Sistema.Cadastro
{
    public partial class LivrosList : System.Web.UI.Page
    {
        #region Methods

        void LoadData()
        {
            var livros = BizLivro.GetLivros();
            gvDados.DataSource = livros;
            gvDados.DataBind();

            lblCount.Text = livros.Count.ToString();
        }

        void Delete()
        {
            try
            {
                BizLivro.Delete(Convert.ToInt32(gvDados.SelectedValue));
                Response.Write("<script>alert('Livro Deletado com sucesso');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Erro! Livro não removido');</script>");
                Response.Write(ex.Message);
            }

            Response.Redirect("LivroList.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }
        protected void gvDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Delete();
        }


        protected void gvDados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDados.PageIndex = e.NewPageIndex;
            LoadData();
        }

        #endregion

    }
}