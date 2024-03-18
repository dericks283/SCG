namespace Chamadaa.View.ViewDC
{
    partial class DCTurmas
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
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.cbModalidades = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtIdTurmas = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.AllowUserToAddRows = false;
            this.dgvTurmas.AllowUserToDeleteRows = false;
            this.dgvTurmas.AllowUserToResizeRows = false;
            this.dgvTurmas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvTurmas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvTurmas.Location = new System.Drawing.Point(25, 180);
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.Size = new System.Drawing.Size(636, 208);
            this.dgvTurmas.TabIndex = 121;
            this.dgvTurmas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurmas_CellClick);
            this.dgvTurmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurmas_CellContentClick);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(164, 151);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 128;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // cbModalidades
            // 
            this.cbModalidades.BackColor = System.Drawing.Color.White;
            this.cbModalidades.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cbModalidades.ForeColor = System.Drawing.Color.Blue;
            this.cbModalidades.FormattingEnabled = true;
            this.cbModalidades.Items.AddRange(new object[] {
            "Basquete",
            "Volei",
            "Futsal",
            "Handebol",
            "Natação"});
            this.cbModalidades.Location = new System.Drawing.Point(25, 151);
            this.cbModalidades.Name = "cbModalidades";
            this.cbModalidades.Size = new System.Drawing.Size(133, 21);
            this.cbModalidades.TabIndex = 126;
            this.cbModalidades.Text = "Modalidade";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(529, 128);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(101, 45);
            this.btnAtualizar.TabIndex = 133;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtIdTurmas
            // 
            this.txtIdTurmas.BackColor = System.Drawing.Color.White;
            this.txtIdTurmas.Enabled = false;
            this.txtIdTurmas.ForeColor = System.Drawing.Color.Blue;
            this.txtIdTurmas.Location = new System.Drawing.Point(447, 55);
            this.txtIdTurmas.Name = "txtIdTurmas";
            this.txtIdTurmas.Size = new System.Drawing.Size(112, 20);
            this.txtIdTurmas.TabIndex = 132;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(565, 52);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 131;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtHorario
            // 
            this.txtHorario.BackColor = System.Drawing.Color.White;
            this.txtHorario.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtHorario.ForeColor = System.Drawing.Color.Blue;
            this.txtHorario.Location = new System.Drawing.Point(25, 84);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(141, 22);
            this.txtHorario.TabIndex = 130;
            this.txtHorario.Text = "Horário referente:";
            // 
            // txtTurma
            // 
            this.txtTurma.BackColor = System.Drawing.Color.White;
            this.txtTurma.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTurma.ForeColor = System.Drawing.Color.Blue;
            this.txtTurma.Location = new System.Drawing.Point(25, 56);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(295, 22);
            this.txtTurma.TabIndex = 129;
            this.txtTurma.Text = "Nome da nova turma:";
            // 
            // DCTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 400);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtIdTurmas);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.cbModalidades);
            this.Controls.Add(this.dgvTurmas);
            this.Name = "DCTurmas";
            this.Text = "DCTurmas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurmas;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.ComboBox cbModalidades;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtIdTurmas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtTurma;
    }
}