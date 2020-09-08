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
            this.btn_exibir = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.dgv_cd = new System.Windows.Forms.DataGridView();
            this.lbl_nomeautor = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exibir
            // 
            this.btn_exibir.Location = new System.Drawing.Point(192, 65);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(179, 30);
            this.btn_exibir.TabIndex = 12;
            this.btn_exibir.Text = "exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(99, 27);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(63, 20);
            this.txt_nome.TabIndex = 11;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(423, 31);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(63, 20);
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
            // 
            // lbl_nomeautor
            // 
            this.lbl_nomeautor.AutoSize = true;
            this.lbl_nomeautor.Location = new System.Drawing.Point(329, 34);
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
            // CD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 299);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.dgv_cd);
            this.Controls.Add(this.lbl_nomeautor);
            this.Controls.Add(this.lbl_nome);
            this.Name = "CD";
            this.Text = "CD";
            this.Load += new System.EventHandler(this.CD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exibir;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.DataGridView dgv_cd;
        private System.Windows.Forms.Label lbl_nomeautor;
        private System.Windows.Forms.Label lbl_nome;
    }
}