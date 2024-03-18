namespace Chamadaa.View.ViewDC
{
    partial class DCTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DCTurma));
            this.txtIdTurmas = new System.Windows.Forms.TextBox();
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.cbModalidades = new System.Windows.Forms.ComboBox();
            this.txtHorario = new System.Windows.Forms.MaskedTextBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdTurmas
            // 
            this.txtIdTurmas.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtIdTurmas.Enabled = false;
            this.txtIdTurmas.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtIdTurmas.ForeColor = System.Drawing.Color.Silver;
            this.txtIdTurmas.Location = new System.Drawing.Point(402, 154);
            this.txtIdTurmas.Name = "txtIdTurmas";
            this.txtIdTurmas.Size = new System.Drawing.Size(130, 23);
            this.txtIdTurmas.TabIndex = 131;
            this.txtIdTurmas.Text = "Identificação";
            this.txtIdTurmas.TextChanged += new System.EventHandler(this.txtIdTurmas_TextChanged);
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.AllowUserToAddRows = false;
            this.dgvTurmas.AllowUserToDeleteRows = false;
            this.dgvTurmas.AllowUserToResizeRows = false;
            this.dgvTurmas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvTurmas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvTurmas.Location = new System.Drawing.Point(105, 210);
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.Size = new System.Drawing.Size(427, 282);
            this.dgvTurmas.TabIndex = 129;
            this.dgvTurmas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurmas_CellClick);
            // 
            // txtTurma
            // 
            this.txtTurma.BackColor = System.Drawing.Color.Black;
            this.txtTurma.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtTurma.ForeColor = System.Drawing.Color.Silver;
            this.txtTurma.Location = new System.Drawing.Point(576, 310);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(196, 23);
            this.txtTurma.TabIndex = 127;
            this.txtTurma.Text = "Nome da Turma:";
            // 
            // cbModalidades
            // 
            this.cbModalidades.BackColor = System.Drawing.Color.Black;
            this.cbModalidades.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.cbModalidades.ForeColor = System.Drawing.Color.Silver;
            this.cbModalidades.FormattingEnabled = true;
            this.cbModalidades.Items.AddRange(new object[] {
            "Basquete",
            "Volei",
            "Futsal",
            "Handebol",
            "Natação"});
            this.cbModalidades.Location = new System.Drawing.Point(639, 210);
            this.cbModalidades.Name = "cbModalidades";
            this.cbModalidades.Size = new System.Drawing.Size(133, 23);
            this.cbModalidades.TabIndex = 126;
            this.cbModalidades.Text = "Modalidade";
            this.cbModalidades.DropDown += new System.EventHandler(this.cbModalidades_DropDown);
            // 
            // txtHorario
            // 
            this.txtHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHorario.BackColor = System.Drawing.Color.Black;
            this.txtHorario.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtHorario.ForeColor = System.Drawing.Color.Silver;
            this.txtHorario.Location = new System.Drawing.Point(683, 357);
            this.txtHorario.Mask = "90:00";
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(89, 23);
            this.txtHorario.TabIndex = 135;
            this.txtHorario.ValidatingType = typeof(System.DateTime);
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCarregar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_carregar;
            this.btnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCarregar.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btnCarregar.ForeColor = System.Drawing.Color.Black;
            this.btnCarregar.Location = new System.Drawing.Point(676, 239);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(96, 37);
            this.btnCarregar.TabIndex = 134;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_carregar;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.Location = new System.Drawing.Point(599, 405);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(173, 50);
            this.btnAtualizar.TabIndex = 133;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::Chamadaa.Properties.Resources.btn_excluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnExcluir.Location = new System.Drawing.Point(433, 182);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 23);
            this.btnExcluir.TabIndex = 130;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Chamadaa.Properties.Resources.Fundo_controle_turmas;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(834, 459);
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // DCTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1068, 600);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtIdTurmas);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvTurmas);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.cbModalidades);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DCTurma";
            this.Text = "DCTurma";
            this.Load += new System.EventHandler(this.DCTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtIdTurmas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvTurmas;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.ComboBox cbModalidades;
        private System.Windows.Forms.MaskedTextBox txtHorario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}