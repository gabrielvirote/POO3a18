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
       
    

    }
}
