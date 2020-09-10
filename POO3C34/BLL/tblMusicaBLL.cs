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
    class tblMusicaBLL
    {
        private DALMysql DaoBanco = new DALMysql();


        public DataTable ListarMusicas(string nome)
        {
            string sql = string.Format($@"select * from tbl_musica where nome = '{nome}';");
            return DaoBanco.executarConsulta(sql);
        }
        public DataTable ListarTodasMusicas()
        {
            string sql = string.Format($@"select * from tbl_musica");
            return DaoBanco.executarConsulta(sql);
        }
        public void AlterarMusica(tblMusicaDTO dtoMusica)
        {
            string sql = string.Format($@"UPDATE tbl_musica set nome = '{dtoMusica.Nome}',
                                                                nomeAutor = '{dtoMusica.NomeAutor}',
                                                                idGravadora = '{dtoMusica.IdGravadora}'                                                               
                                                                where idMusica = '{dtoMusica.IdMusica}';");
            DaoBanco.executarComando(sql);
        }
        public void InserirMusica(tblMusicaDTO ObjMusica)
        {
            string sql = string.Format($@"INSERT INTO tbl_musica VALUES (NULL,'{ObjMusica.Nome}','{ObjMusica.NomeAutor}','{ObjMusica.IdGravadora}','{ObjMusica.IdCD}');");
            DaoBanco.executarComando(sql);
        }
        public void ExcluirMusica(tblMusicaDTO objMusica)
        {
            string sql = string.Format($@"DELETE FROM tbl_musica where idMusica = {objMusica.IdMusica};");
            DaoBanco.executarComando(sql);
        }
        public DataTable PesquisarMusica(string condicao)
        {
            string sql = string.Format($@"select * from tbl_musica where " + condicao);
            return DaoBanco.executarConsulta(sql);
        }
    }
}

