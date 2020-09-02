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
        public string Nome { get => nome; set => nome = value; }
        public string NomeAutor { get => nomeAutor; set => nomeAutor = value; }
        public object Id_Musica { get; internal set; }
    }
}
