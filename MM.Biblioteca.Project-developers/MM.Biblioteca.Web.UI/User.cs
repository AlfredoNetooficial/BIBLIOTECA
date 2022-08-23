using MM.Biblioteca.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MM.Biblioteca.Web.UI
{
    public class User
    {
        public TBFUNCIONARIO ConsultUser(string pEmail, string pSenha)
        {
            using (BIBLIOTECAEntities dc = new BIBLIOTECAEntities())
            {
               return dc.TBFUNCIONARIO.Where(p => p.EMAIL == pEmail && p.SENHA == pSenha).FirstOrDefault();
            }

        }
    }
}