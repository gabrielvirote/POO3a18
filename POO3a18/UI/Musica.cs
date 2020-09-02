using System;
using POO3a18.DTO;
using POO3a18.DAL;
using POO3a18.BLL;
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
    public partial class Musica : Form
    {
        tblMusicaBLL bllCliente = new tblMusicaBLL();
        tblMusicaDTO dtoCliente = new tblMusicaDTO();
       
        public Musica()
        {
            InitializeComponent();
        }

        private void exibir_Click(object sender, EventArgs e)
        {
            string condicao = "nome like '%" + txt_autor.Text + "%'" +
                             "or nomeAutor like '%" + txt_nome.Text + "%'";
                            
            dgv_musica.DataSource = bllCliente.PesquisarClientes(condicao);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                txt_nome.Text = dgv_musica.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_autor.Text = dgv_musica.Rows[e.RowIndex].Cells[1].Value.ToString();
               

            }
        }
}
