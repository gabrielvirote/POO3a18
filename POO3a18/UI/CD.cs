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
    public partial class Cd : Form
    {
        tblCdBLL bllCd = new tblCdBLL();
        tblCdDTO dtoCd = new tblCdDTO();
        public Cd()
        {
            InitializeComponent();
        }

        private void CD_Load(object sender, EventArgs e)
        {
            dgv_cd.DataSource = bllCd.PesquisarCd();
        }

        private void btn_exibir_Click(object sender, EventArgs e)
        {
            string condicao = "nomeCd like '%" + txt_preco.Text + "%'" +
                             "or precoVenda like '%" + txt_nome.Text + "%'";

            dgv_cd.DataSource = bllCd.PesquisarCd(condicao);
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                // Passo os dados para o DTO
                dtoCd.NomeCD = txt_nome.Text.ToString();
                dtoCd.NomeCD = txt_preco.Text.ToString();


                bllCd.AdicionarCd(dtoCd);
                MessageBox.Show("Inserção Realizada com Sucesso. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_cd.DataSource = bllCd.PesquisarCd();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            dtoCd.NomeCD = txt_nome.Text.ToString();
            dtoCd.NomeCD = txt_preco.Text.ToString();


            bllCd.EditarCd(dtoCd);
            dgv_cd.DataSource = bllCd.PesquisarCd();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoCd.IdCD = Convert.ToInt32(txt_nome.Text);
                    bllCd.ExcluirCd(dtoCd);
                    dgv_cd.DataSource = bllCd.PesquisarCd();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_cd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nome.Text = dgv_cd.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_preco.Text = dgv_cd.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
    }

