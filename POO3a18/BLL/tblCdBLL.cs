﻿using System;
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
    }
}
