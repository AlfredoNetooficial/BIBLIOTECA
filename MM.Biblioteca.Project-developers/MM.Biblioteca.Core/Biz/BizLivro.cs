using MM.Biblioteca.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Biblioteca.Core.Biz
{
    public class BizLivro
    {

        #region CRUD

        public static List<TBLIVRO> GetLivros()
        {
            using (BIBLIOTECAEntities dc = new BIBLIOTECAEntities())
            {
                var q = from x in dc.TBLIVRO.Include("TBEDITORA")
                        select x;

                return q.ToList();
            }
        }

        public static TBLIVRO GetLivro(int pIDLivro)
        {
            using (BIBLIOTECAEntities dc = new BIBLIOTECAEntities())
            {
                return dc.TBLIVRO.Include("TBEDITORA").FirstOrDefault(p => p.IDLIVRO == pIDLivro);
            }          
        }

        public static TBLIVRO Insert(int pIdEditora, string pNome, string pAssunto, bool pStatus, string pAutor)
        {
            using (BIBLIOTECAEntities dc = new BIBLIOTECAEntities())
            {
                TBLIVRO _livro = new TBLIVRO()
                {
                   IDEDITORA = pIdEditora,
                   NOME = pNome,
                   ASSUNTO = pAssunto,
                   STATUS = pStatus,
                   AUTOR = pAutor,

                };

                dc.TBLIVRO.Add(_livro);
                dc.SaveChanges();

                return _livro;

            }

        }

        public static void Update(int pIdLivro,int pIdEditora, string pNome, string pAssunto, bool pStatus, string pAutor)
        {
            using (BIBLIOTECAEntities dc = new BIBLIOTECAEntities())
            {
                TBLIVRO _livro = dc.TBLIVRO.Include("TBEDITORA").FirstOrDefault(p => p.IDLIVRO == pIdLivro);

                _livro.IDEDITORA = pIdEditora;
                _livro.NOME = pNome;
                _livro.ASSUNTO = pAssunto;
                _livro.STATUS = pStatus;
                _livro.AUTOR = pAutor;

                dc.SaveChanges();
            }
        }

        public static void Delete(int pIDLivro)
        {
            using (BIBLIOTECAEntities dc = new BIBLIOTECAEntities())
            {

                TBLIVRO _livro = dc.TBLIVRO.Include("TBEDITORA").FirstOrDefault(p => p.IDLIVRO == pIDLivro);

                dc.TBLIVRO.Remove(_livro);
                dc.SaveChanges();

            }
        }

        #endregion

    }
}
