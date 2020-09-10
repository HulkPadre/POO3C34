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
    class tblGravadoraBLL
    {
        private DALMysql DaoBanco = new DALMysql();

        public DataTable ListarGravadorasPorNome(string nome)
        {
            string sql = string.Format($@"select * from tbl_gravadora where nome = '{nome}';");
            return DaoBanco.executarConsulta(sql);
        }
        public DataTable ListarTodasGravadoras()
        {
            string sql = string.Format($@"select * from tbl_gravadora");
            return DaoBanco.executarConsulta(sql);
        }
        public void AlterarGravadora(tblGravadoraDTO dtoGravadora)
        {
            string sql = string.Format($@"UPDATE tbl_gravadora set nome = '{dtoGravadora.Nome}'                                                                                                                             
                                                                   where idGravadora = '{dtoGravadora.IdGravadora}';");
            DaoBanco.executarComando(sql);

        }
        public void InserirGravadora(tblGravadoraDTO objGravadora)
        {
            string sql = string.Format($@"INSERT INTO tbl_gravadora VALUES (NULL,'{objGravadora.Nome}');");
            DaoBanco.executarComando(sql);


        }
        public void ExcluirGravadora(tblGravadoraDTO objGravadora)
        {
            string sql = string.Format($@"DELETE FROM tbl_gravadora where idGravadora = {objGravadora.IdGravadora};");
            DaoBanco.executarComando(sql);
        }
        public DataTable PesquisarGravadora(string condicao)
        {
            string sql = string.Format($@"select * from tbl_gravadora where " + condicao);
            return DaoBanco.executarConsulta(sql);
        }
    }
}
