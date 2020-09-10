namespace POO3a18.UI
{
    partial class Cd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.dgv_cd = new System.Windows.Forms.DataGridView();
            this.lbl_nomeautor = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(28, 81);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(118, 30);
            this.btn_pesquisar.TabIndex = 12;
            this.btn_pesquisar.Text = "pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(99, 27);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(123, 20);
            this.txt_nome.TabIndex = 11;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(407, 31);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(98, 20);
            this.txt_preco.TabIndex = 10;
            // 
            // dgv_cd
            // 
            this.dgv_cd.AllowUserToAddRows = false;
            this.dgv_cd.AllowUserToDeleteRows = false;
            this.dgv_cd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cd.Location = new System.Drawing.Point(28, 117);
            this.dgv_cd.Name = "dgv_cd";
            this.dgv_cd.ReadOnly = true;
            this.dgv_cd.Size = new System.Drawing.Size(519, 134);
            this.dgv_cd.TabIndex = 9;
            this.dgv_cd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cd_CellContentClick);
            // 
            // lbl_nomeautor
            // 
            this.lbl_nomeautor.AutoSize = true;
            this.lbl_nomeautor.Location = new System.Drawing.Point(319, 34);
            this.lbl_nomeautor.Name = "lbl_nomeautor";
            this.lbl_nomeautor.Size = new System.Drawing.Size(37, 13);
            this.lbl_nomeautor.TabIndex = 8;
            this.lbl_nomeautor.Text = "preço ";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(46, 34);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 7;
            this.lbl_nome.Text = "Nome";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(169, 81);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(112, 30);
            this.btn_adicionar.TabIndex = 13;
            this.btn_adicionar.Text = "adicioanar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(303, 81);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(107, 30);
            this.btn_editar.TabIndex = 14;
            this.btn_editar.Text = "editar";
            this.btn_editar.UseVisualStyleBackColor = true;

            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(419, 81);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(128, 30);
            this.btn_excluir.TabIndex = 15;
            this.btn_excluir.Text = "excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // Cd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 299);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.dgv_cd);
            this.Controls.Add(this.lbl_nomeautor);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Cd";
            this.Text = "CD";
            this.Load += new System.EventHandler(this.CD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.DataGridView dgv_cd;
        private System.Windows.Forms.Label lbl_nomeautor;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
    }
}