namespace Chamadaa.View.ViewEventos
{
    partial class Form_notificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_notificar));
            this.txtNomeAlu = new System.Windows.Forms.TextBox();
            this.dgAlunos = new System.Windows.Forms.DataGridView();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbXNoti = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXNoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeAlu
            // 
            this.txtNomeAlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeAlu.BackColor = System.Drawing.Color.Black;
            this.txtNomeAlu.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAlu.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeAlu.Location = new System.Drawing.Point(396, 139);
            this.txtNomeAlu.Name = "txtNomeAlu";
            this.txtNomeAlu.Size = new System.Drawing.Size(290, 27);
            this.txtNomeAlu.TabIndex = 8;
            this.txtNomeAlu.Text = "Nome:";
            this.txtNomeAlu.Enter += new System.EventHandler(this.txtNomeAlu_Enter);
            this.txtNomeAlu.Leave += new System.EventHandler(this.txtNomeAlu_Leave);
            // 
            // dgAlunos
            // 
            this.dgAlunos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAlunos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlunos.Location = new System.Drawing.Point(58, 210);
            this.dgAlunos.Name = "dgAlunos";
            this.dgAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAlunos.Size = new System.Drawing.Size(628, 214);
            this.dgAlunos.TabIndex = 7;
            // 
            // cbBusca
            // 
            this.cbBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbBusca.BackColor = System.Drawing.Color.Black;
            this.cbBusca.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBusca.ForeColor = System.Drawing.Color.Silver;
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Aluno",
            "Professor",
            "Fornecedor"});
            this.cbBusca.Location = new System.Drawing.Point(58, 137);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(159, 28);
            this.cbBusca.TabIndex = 10;
            this.cbBusca.Text = "Pesquisar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Notificar Usuários";
            // 
            // pbXNoti
            // 
            this.pbXNoti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbXNoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbXNoti.Image = global::Chamadaa.Properties.Resources.X;
            this.pbXNoti.Location = new System.Drawing.Point(882, 25);
            this.pbXNoti.Name = "pbXNoti";
            this.pbXNoti.Size = new System.Drawing.Size(29, 26);
            this.pbXNoti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbXNoti.TabIndex = 15;
            this.pbXNoti.TabStop = false;
            this.pbXNoti.Visible = false;
            this.pbXNoti.Click += new System.EventHandler(this.pbXNoti_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Location = new System.Drawing.Point(0, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 50);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarregar.BackColor = System.Drawing.Color.Gray;
            this.btnCarregar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_carregar;
            this.btnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarregar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCarregar.Location = new System.Drawing.Point(223, 137);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(134, 42);
            this.btnCarregar.TabIndex = 11;
            this.btnCarregar.Text = "Carregar \r\n";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.BackColor = System.Drawing.Color.Gray;
            this.btnPesquisar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_Pesquisar;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPesquisar.Location = new System.Drawing.Point(572, 172);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 32);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Chamadaa.Properties.Resources.Fundo_Notificações_campainha;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(208, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 51);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form_notificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Chamadaa.Properties.Resources.fundo_form_notificar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 528);
            this.Controls.Add(this.pbXNoti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.cbBusca);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtNomeAlu);
            this.Controls.Add(this.dgAlunos);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_notificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                     ";
            this.Load += new System.EventHandler(this.Form_notificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXNoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomeAlu;
        public System.Windows.Forms.DataGridView dgAlunos;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pbXNoti;
    }
}