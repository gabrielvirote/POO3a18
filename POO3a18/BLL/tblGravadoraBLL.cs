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
    class tblGravadoraBLL
    {
        private DALBD daoBanco = new DALBD();

        public DataTable PesquisarGravadora(string condicao)
        {
            string sql = string.Format($@"select * from tbl_Gravadora" + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }
        public DataTable PesquisarGravadora()
        {
            string sql = string.Format($@"select * from tbl_Gravadora");
            return daoBanco.ExecutarConsulta(sql);
        }
        public void ExcluirGravadora(tblGravadoraDTO objGravadora)
        {
            string sql = string.Format($@"DELETE FROM tbl_gravadora where id_gravadora = {objGravadora.IdGravadora};");
            daoBanco.ExecutarComando(sql);
        }
        public void EditarGravadora(tblGravadoraDTO DtoGravadora)
        {
            string sql = string.Format($@"UPDATE tbl_gravadora set nome = '{DtoGravadora.Nome}';");

            daoBanco.ExecutarComando(sql);
        }
        public void AdicionarGravadora(tblGravadoraDTO ObjGravadora)
        {
            string sql = string.Format($@"INSERT INTO tbl_cl VALUES (NULL, '{ObjGravadora.Nome}';");

            daoBanco.ExecutarComando(sql);
        }

    }
}
