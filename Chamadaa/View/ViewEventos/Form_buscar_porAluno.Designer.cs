namespace Chamadaa.View.ViewEventos
{
    partial class Form_buscar_porAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_buscar_porAluno));
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.dgAlunos = new System.Windows.Forms.DataGridView();
            this.pbXAln = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXAln)).BeginInit();
            this.SuspendLayout();
            // 
            // cbModalidade
            // 
            this.cbModalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbModalidade.BackColor = System.Drawing.Color.Black;
            this.cbModalidade.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModalidade.ForeColor = System.Drawing.Color.Silver;
            this.cbModalidade.FormattingEnabled = true;
            this.cbModalidade.Items.AddRange(new object[] {
            "Basquete",
            "Futsal",
            "Volei",
            "Natacao"});
            this.cbModalidade.Location = new System.Drawing.Point(12, 97);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(174, 26);
            this.cbModalidade.TabIndex = 8;
            this.cbModalidade.Text = "Modalidades";
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_carregar;
            this.btnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarregar.Location = new System.Drawing.Point(15, 148);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(174, 50);
            this.btnCarregar.TabIndex = 134;
            this.btnCarregar.Text = "Carregar Alunos";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // dgAlunos
            // 
            this.dgAlunos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlunos.Location = new System.Drawing.Point(195, 47);
            this.dgAlunos.Name = "dgAlunos";
            this.dgAlunos.Size = new System.Drawing.Size(490, 188);
            this.dgAlunos.TabIndex = 135;
            // 
            // pbXAln
            // 
            this.pbXAln.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbXAln.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbXAln.Image = global::Chamadaa.Properties.Resources.X;
            this.pbXAln.Location = new System.Drawing.Point(699, 12);
            this.pbXAln.Name = "pbXAln";
            this.pbXAln.Size = new System.Drawing.Size(20, 20);
            this.pbXAln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbXAln.TabIndex = 136;
            this.pbXAln.TabStop = false;
            this.pbXAln.Click += new System.EventHandler(this.iconFechar_Click);
            // 
            // Form_buscar_porAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 289);
            this.Controls.Add(this.pbXAln);
            this.Controls.Add(this.dgAlunos);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.cbModalidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_buscar_porAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_buscar_porAluno";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXAln)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbModalidade;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.DataGridView dgAlunos;
        public System.Windows.Forms.PictureBox pbXAln;
    }
}