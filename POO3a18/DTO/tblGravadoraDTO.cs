using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3a18.DTO
{
    class tblGravadoraDTO
    {
        private int idGravadora;
        private string nome;

        public int IdGravadora { get => idGravadora; set => idGravadora = value; }
     
        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo Nome da gravadora é obrigatório.");
                }

            }
            get { return this.nome; }
        }

    }
}
