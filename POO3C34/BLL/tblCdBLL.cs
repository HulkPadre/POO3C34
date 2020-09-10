using POO3C34.DAL;
using POO3C34.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3C34.BLL
{
    class tblCdBLL
    {
        private DALMysql DaoBanco = new DALMysql();        
       
        
        public DataTable ListarCdPorNome(string nome)
        {
            string sql = string.Format($@"select * from tbl_cd where nome = '{nome}';");
            return DaoBanco.executarConsulta(sql);
        }
        public DataTable ListarTodosCd()
        {
            string sql = string.Format($@"select * from tbl_cd");
            return DaoBanco.executarConsulta(sql);
        }
        public void AlterarCD(tblCdDTO dtoCd)
        {
            string sql = string.Format($@"UPDATE tbl_cd set nomeCD = '{dtoCd.NomeCD}',
                                                               precoVenda = '{dtoCd.PrecoVenda}',
                                                               dtLancamento = '{dtoCd.DtLancamento}'                                                               
                                                               where idCD = '{dtoCd.IdCD}';");
            DaoBanco.executarComando(sql);

        }

        public void InserirCD(tblCdDTO ObjCD)
        {
            string sql = string.Format($@"INSERT INTO tbl_cliente VALUES (NULL,'{ObjCD.NomeCD}',
                                                                          '{ObjCD.PrecoVenda}',
                                                                          '{ObjCD.DtLancamento}');");
            DaoBanco.executarComando(sql);


        }

        public void ExcluirCD(tblCdDTO objCD)
        {
            string sql = string.Format($@"DELETE FROM tbl_cd where idCD = {objCD.IdCD};");
            DaoBanco.executarComando(sql);
        }

        public DataTable PesquisarCD(string condicao)
        {
            string sql = string.Format($@"select * from tbl_cd where " + condicao);
            return DaoBanco.executarConsulta(sql);
        }

    }
}
