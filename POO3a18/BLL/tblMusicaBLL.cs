using System;
using POO3a18.DTO;
using POO3a18.DAL;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3a18.BLL
{
    class tblMusicaBLL
    {
        private DALBD daoBanco = new DALBD();


        public DataTable PesquisarMusica(string condicao)
        {
            string sql = string.Format($@"select * from tbl_Musica where " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }

        public DataTable PesquisarMusica()
        {
            string sql = string.Format($@"select * from tbl_Musica");
            return daoBanco.ExecutarConsulta(sql);
        }
        public void ExcluirMusica (tblMusicaDTO objMusica)
        {
            string sql = string.Format($@"DELETE FROM tbl_musica where id_musica = {objMusica.Id_Musica};");
            daoBanco.ExecutarComando(sql);
        }
        public void EditarMusica(tblMusicaDTO DtoMusica)
        {
            string sql = string.Format($@"UPDATE tbl_musica set nome = '{DtoMusica.Nome}',
                                                                 Nome_autor = '{DtoMusica.NomeAutor}';");
                                                                
            daoBanco.ExecutarComando(sql);
        }
        public void AdicionarMusica(tblMusicaDTO ObjMusica)
        {
            string sql = string.Format($@"INSERT INTO tbl_cliente VALUES (NULL, '{ObjMusica.Nome}',
                                                                                '{ObjMusica.NomeAutor}';");
                                                                                
            daoBanco.ExecutarComando(sql);
        }


    }
}
