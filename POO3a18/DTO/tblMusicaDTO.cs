using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3a18.DTO
{
    class tblMusicaDTO
    {
        private int idMusica,idGravadora,idCD;
        private string nome,nomeAutor;
        public int IdMusica { get => idMusica; set => idMusica = value; }
        public int IdGravadora { get => idGravadora; set => idGravadora = value; }
        public int IdCD { get => idCD; set => idCD = value; }

      
        public object Id_Musica { get; internal set; }

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
                    throw new Exception("O campo Nome da musica é obrigatório.");
                }

            }
            get { return this.nome; }
        }
        public string NomeAutor
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeAutor = value;
                }
                else
                {
                    throw new Exception("O campo Nome do autor é obrigatório.");
                }

            }
            get { return this.nomeAutor; }
        }
    }
}
