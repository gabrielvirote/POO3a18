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
    }
}
