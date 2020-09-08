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
   
        public double PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public string NomeCD
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeCD = value;
                }
                else
                {
                    throw new Exception("O campo Nome da musica é obrigatório.");
                }

            }
            get { return this.nomeCD; }
        }
    }
}
