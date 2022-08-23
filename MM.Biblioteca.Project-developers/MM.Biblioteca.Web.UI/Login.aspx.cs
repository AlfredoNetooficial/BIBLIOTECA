using MM.Biblioteca.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MM.Biblioteca.Web.UI
{
    public partial class Login : System.Web.UI.Page
    {
        #region propriedades



        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            txtSenha.Focus();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)

        {
            try
            {
                User usuario = new User();

                TBFUNCIONARIO tBFUNCIONARIO = new TBFUNCIONARIO();

                tBFUNCIONARIO = usuario.ConsultUser(txtEmail.Text, txtSenha.Text);

                if (tBFUNCIONARIO == null)
                {
                    Response.Write("<script>alert('Usuário ou senha incorretos. Porfavor tente novamente');</script>");
                }
                else
                {
                    

                    Response.Redirect("~/Sistema/Home.aspx");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Response.Write("<script>alert('Usuário ou senha incorretos. Porfavor tente novamente');</script>");

            }


        }
    }
}
