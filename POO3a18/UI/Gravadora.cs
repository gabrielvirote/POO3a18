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
        tblGravadoraBLL bllGravadora = new tblGravadoraBLL();
        tblGravadoraDTO dtoGravadora = new tblGravadoraDTO();
        public Gravadora()
        {
            InitializeComponent();
        }

        private void Gravadora_Load(object sender, EventArgs e)
        {
            dgv_gravadora.DataSource = bllGravadora.PesquisarGravadora();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condicao = "nome like '%" + txt_nome.Text + "%'" ;

            dgv_gravadora.DataSource = bllGravadora.PesquisarGravadora(condicao);
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Passo os dados para o DTO
                dtoGravadora.Nome = txt_nome.Text.ToString();
            




                bllGravadora.AdicionarGravadora(dtoGravadora);
                MessageBox.Show("Inserção Realizada com Sucesso. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_gravadora.DataSource = bllGravadora.PesquisarGravadora();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            // Passo os dados para o DTO
            dtoGravadora.Nome = txt_nome.Text.ToString();
           

            bllGravadora.EditarGravadora(dtoGravadora);
            dgv_gravadora.DataSource = bllGravadora.PesquisarGravadora();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoGravadora.IdGravadora = Convert.ToInt32(txt_nome.Text);
                    bllGravadora.ExcluirGravadora(dtoGravadora);
                    dgv_gravadora.DataSource = bllGravadora.PesquisarGravadora();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_gravadora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nome.Text = dgv_gravadora.Rows[e.RowIndex].Cells[0].Value.ToString();
           
        }
    }
    }

