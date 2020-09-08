using POO3a18.BLL;
using POO3a18.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO3a18.UI
{
    public partial class Gravadora : Form
    {
        tblGravadoraBLL bllMusica = new tblGravadoraBLL();
        tblGravadoraDTO dtoMusica = new tblGravadoraDTO();
        public Gravadora()
        {
            InitializeComponent();
        }

        private void Gravadora_Load(object sender, EventArgs e)
        {
            dgv_gravadora.DataSource = bllMusica.PesquisarGravadora();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condicao = "nome like '%" + txt_nome.Text + "%'" ;

            dgv_gravadora.DataSource = bllMusica.PesquisarGravadora(condicao);
        }
    }
}
