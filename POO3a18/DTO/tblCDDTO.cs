using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3a18.DTO
{
    class tblCdDTO
    {
        private int idCD;
        private string nomeCD;
        private double precoVenda;

        public int IdCD { get => idCD; set => idCD = value; }
        public string NomeCD { get => nomeCD; set => nomeCD = value; }
        public double PrecoVenda { get => precoVenda; set => precoVenda = value; }
    }
}
