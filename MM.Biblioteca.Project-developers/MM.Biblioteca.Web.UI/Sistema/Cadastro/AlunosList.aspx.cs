using MM.Biblioteca.Core.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MM.Biblioteca.Web.UI.Sistema
{
    public partial class Alunos : System.Web.UI.Page
    {
        #region Methods

        void LoadData()
        {
            var alunos = BizAluno.GetAlunos();
            gvDados.DataSource = alunos;
            gvDados.DataBind();

            lblCount.Text = alunos.Count.ToString();
        }

        void Delete()
        {
            try
            {
                BizAluno.Delete(Convert.ToInt32(gvDados.SelectedValue));
                Response.Write("<script>alert('Aluno Deletado com sucesso');</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Erro! Aluno não removido');</script>");
                Response.Write(ex.Message);
            }

            Response.Redirect("AlunosList.aspx");
        }

        #endregion
        #region events
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
        #endregion

        protected void gvDados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDados.PageIndex = e.NewPageIndex;
            LoadData();
        }
    }
}