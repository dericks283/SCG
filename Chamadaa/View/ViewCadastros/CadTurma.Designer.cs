namespace Chamadaa.View.ViewCadastros
{
    partial class CadTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadTurma));
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            this.cbModalidades = new System.Windows.Forms.ComboBox();
            this.txtNovaTur = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.MaskedTextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horario Referente:";
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmas.Location = new System.Drawing.Point(278, 344);
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.Size = new System.Drawing.Size(404, 150);
            this.dgvTurmas.TabIndex = 4;
            // 
            // cbModalidades
            // 
            this.cbModalidades.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.cbModalidades.Location = new System.Drawing.Point(305, 246);
            this.cbModalidades.Name = "cbModalidades";
            this.cbModalidades.Size = new System.Drawing.Size(121, 23);
            this.cbModalidades.TabIndex = 5;
            this.cbModalidades.Text = "Modalidade";
            // 
            // txtNovaTur
            // 
            this.txtNovaTur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNovaTur.BackColor = System.Drawing.Color.Black;
            this.txtNovaTur.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtNovaTur.ForeColor = System.Drawing.Color.Silver;
            this.txtNovaTur.Location = new System.Drawing.Point(305, 309);
            this.txtNovaTur.Name = "txtNovaTur";
            this.txtNovaTur.Size = new System.Drawing.Size(221, 23);
            this.txtNovaTur.TabIndex = 6;
            this.txtNovaTur.Text = "Nome da nova Turma*";
            this.txtNovaTur.Enter += new System.EventHandler(this.txtNovaTur_Enter);
            this.txtNovaTur.Leave += new System.EventHandler(this.txtNovaTur_Leave);
            // 
            // txtHorario
            // 
            this.txtHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHorario.BackColor = System.Drawing.Color.Black;
            this.txtHorario.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtHorario.ForeColor = System.Drawing.Color.Silver;
            this.txtHorario.Location = new System.Drawing.Point(571, 246);
            this.txtHorario.Mask = "90:00";
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(71, 23);
            this.txtHorario.TabIndex = 10;
            this.txtHorario.ValidatingType = typeof(System.DateTime);
            // 
            // btnCad
            // 
            this.btnCad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCad.BackgroundImage = global::Chamadaa.Properties.Resources.btn_cadastrar;
            this.btnCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCad.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCad.Location = new System.Drawing.Point(550, 301);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(112, 35);
            this.btnCad.TabIndex = 8;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Chamadaa.Properties.Resources.fundo_cad_Turmas;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(98, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(772, 484);
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Silver;
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnReset.Location = new System.Drawing.Point(607, 500);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 121;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // CadTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.txtNovaTur);
            this.Controls.Add(this.cbModalidades);
            this.Controls.Add(this.dgvTurmas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadTurma";
            this.Text = "CadTurma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTurmas;
        private System.Windows.Forms.ComboBox cbModalidades;
        private System.Windows.Forms.TextBox txtNovaTur;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.MaskedTextBox txtHorario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReset;
    }
}