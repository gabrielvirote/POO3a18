namespace POO3a18.UI
{
    partial class Gravadora
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
            this.dgv_gravadora = new System.Windows.Forms.DataGridView();
            this.lbl_nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gravadora)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exibir
            // 
            this.btn_exibir.Location = new System.Drawing.Point(327, 66);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(216, 46);
            this.btn_exibir.TabIndex = 12;
            this.btn_exibir.Text = "exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(144, 80);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 11;
            // 
            // dgv_gravadora
            // 
            this.dgv_gravadora.AllowUserToAddRows = false;
            this.dgv_gravadora.AllowUserToDeleteRows = false;
            this.dgv_gravadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gravadora.Location = new System.Drawing.Point(25, 138);
            this.dgv_gravadora.Name = "dgv_gravadora";
            this.dgv_gravadora.ReadOnly = true;
            this.dgv_gravadora.Size = new System.Drawing.Size(556, 150);
            this.dgv_gravadora.TabIndex = 9;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(49, 80);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 7;
            this.lbl_nome.Text = "Nome";
            // 
            // Gravadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 336);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.dgv_gravadora);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Gravadora";
            this.Text = "Gravadora";
            this.Load += new System.EventHandler(this.Gravadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gravadora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exibir;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.DataGridView dgv_gravadora;
        private System.Windows.Forms.Label lbl_nome;
    }
}