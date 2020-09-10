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
    class tblCdBLL
    {
        private DALBD daoBanco = new DALBD();

        public DataTable PesquisarCd(string condicao)
        {
            string sql = string.Format($@"select * from tbl_cd" + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }
        public DataTable PesquisarCd()
        {
            string sql = string.Format($@"select * from tbl_cd");
            return daoBanco.ExecutarConsulta(sql);
        }
        public void ExcluirCd(tblCdDTO objCd)
        {
            string sql = string.Format($@"DELETE FROM tbl_Cd where id_Cd = {objCd.IdCD};");
            daoBanco.ExecutarComando(sql);
        }
        public void EditarCd(tblCdDTO DtoCd)
        {
            string sql = string.Format($@"UPDATE tbl_Cd set nome = '{DtoCd.NomeCD}',
                                           where Preço_venda = '{DtoCd.PrecoVenda}'; ");

            daoBanco.ExecutarComando(sql);
        }
        public void AdicionarCd(tblCdDTO ObjCd)
        {
            string sql = string.Format($@"INSERT INTO tbl_Cd VALUES (NULL, '{ObjCd.NomeCD}', 
                                                                           '{ObjCd.PrecoVenda}'); ");

            daoBanco.ExecutarComando(sql);
        }
    }
}
