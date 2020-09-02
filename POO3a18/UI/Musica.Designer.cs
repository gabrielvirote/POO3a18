namespace POO3a18.UI
{
    partial class Musica
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_nomeautor = new System.Windows.Forms.Label();
            this.dgv_musica = new System.Windows.Forms.DataGridView();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_exibir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musica)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(30, 42);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_nomeautor
            // 
            this.lbl_nomeautor.AutoSize = true;
            this.lbl_nomeautor.Location = new System.Drawing.Point(313, 42);
            this.lbl_nomeautor.Name = "lbl_nomeautor";
            this.lbl_nomeautor.Size = new System.Drawing.Size(66, 13);
            this.lbl_nomeautor.TabIndex = 1;
            this.lbl_nomeautor.Text = "Nome Autor ";
            // 
            // dgv_musica
            // 
            this.dgv_musica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_musica.Location = new System.Drawing.Point(12, 125);
            this.dgv_musica.Name = "dgv_musica";
            this.dgv_musica.Size = new System.Drawing.Size(556, 150);
            this.dgv_musica.TabIndex = 3;
            this.dgv_musica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(418, 35);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(100, 20);
            this.txt_autor.TabIndex = 4;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(83, 35);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // btn_exibir
            // 
            this.btn_exibir.Location = new System.Drawing.Point(176, 73);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(216, 46);
            this.btn_exibir.TabIndex = 6;
            this.btn_exibir.Text = "exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.exibir_Click);
            // 
            // Musica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 298);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.dgv_musica);
            this.Controls.Add(this.lbl_nomeautor);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Musica";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_musica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_nomeautor;
        private System.Windows.Forms.DataGridView dgv_musica;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_exibir;
    }
}