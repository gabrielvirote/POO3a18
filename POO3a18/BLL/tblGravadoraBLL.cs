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

        public DataTable ListarFornecedores()
        {
            string sql = string.Format($@"select * from tbl_Gravadora");
            return daoBanco.ExecutarConsulta(sql);
        }
    }
}
