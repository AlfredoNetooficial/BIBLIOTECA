using MM.Biblioteca.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Biblioteca.Core.Biz
{
    public static class BizAluno
    {
        //TODO
        // Fazer CRUD com Entity fremework

        #region CRUD
        public static List<TBALUNO> GetAlunos()
        {
            using (BIBLIOTECAEntities dc = new BIBLIOTECAEntities())
            {
                var q = from x in dc.TBALUNO
                        select x;

                return q.ToList();
            }
        }
        public static TBALUNO GetAluno(int pIDAluno)
        {
            using (BIBLIOTECAEntities dc = new BIBLIOTECAEntities())
            {
                return dc.TBALUNO.FirstOrDefault(p => p.IDALUNO == pIDAluno);
            }
        }

        public static TBALUNO Insert(string pNome, string pTelefone, string pCPF, string pRua, string pBairro, string pCidade,
            string pUF,  string pMatricula, bool pSituacao)
        {
            using (BIBLIOTECAEntities dc = new BIBLIOTECAEntities())
            {
                TBALUNO _aluno = new TBALUNO()
                {
                    NOME = pNome,
                    TELEFONE = pTelefone,
                    CPF = pCPF,
                    RUA = pRua,
                    BAIRRO = pBairro,
                    CIDADE = pCidade,
                    UF = pUF,
                    //MULTAS = pMultas,
                    SITUACAO = pSituacao,
                    MATRICULA = pMatricula,

                };

                dc.TBALUNO.Add(_aluno);
                dc.SaveChanges();

                return _aluno;

            }

        }

        public static void Update(int pIDAluno, string pNome, string pTelefone, string pCPF, string pRua, string pBairro, string pCidade,
            string pUF, bool pSituacao, string pMatricula)
        {
            using (BIBLIOTECAEntities dc = new BIBLIOTECAEntities())
            {
                TBALUNO _aluno = dc.TBALUNO.FirstOrDefault(p => p.IDALUNO == pIDAluno);

                _aluno.NOME = pNome;
                _aluno.TELEFONE = pTelefone;
                _aluno.CPF = pCPF;
                _aluno.RUA = pRua;
                _aluno.BAIRRO = pBairro;
                _aluno.CIDADE = pCidade;
                _aluno.UF = pUF;
               // _aluno.MULTAS = pMultas;
                _aluno.SITUACAO = pSituacao;
                _aluno.MATRICULA = pMatricula;

                dc.SaveChanges();


            }

        }

        public static void Delete(int pIDAluno)
        {
            using (BIBLIOTECAEntities dc = new BIBLIOTECAEntities())
            {

                TBALUNO _aluno = dc.TBALUNO.FirstOrDefault(p => p.IDALUNO == pIDAluno);

                dc.TBALUNO.Remove(_aluno);
                dc.SaveChanges();




            }
        }
        #endregion

    }
}
