namespace Chamadaa.View.ViewEventos
{
    partial class CDEventos
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
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtOrganizador = new System.Windows.Forms.TextBox();
            this.txtNomeevt = new System.Windows.Forms.TextBox();
            this.dgEventos = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModalidade
            // 
            this.txtModalidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtModalidade.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModalidade.Location = new System.Drawing.Point(84, 486);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(142, 26);
            this.txtModalidade.TabIndex = 134;
            this.txtModalidade.Text = "Modalidade";
            // 
            // txtLocal
            // 
            this.txtLocal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLocal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(84, 436);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(196, 26);
            this.txtLocal.TabIndex = 133;
            this.txtLocal.Text = "Local";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtData.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(508, 384);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(245, 26);
            this.txtData.TabIndex = 132;
            this.txtData.Text = "Data";
            // 
            // txtOrganizador
            // 
            this.txtOrganizador.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOrganizador.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizador.Location = new System.Drawing.Point(544, 436);
            this.txtOrganizador.Name = "txtOrganizador";
            this.txtOrganizador.Size = new System.Drawing.Size(209, 26);
            this.txtOrganizador.TabIndex = 131;
            this.txtOrganizador.Text = "Organizador";
            // 
            // txtNomeevt
            // 
            this.txtNomeevt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNomeevt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeevt.Location = new System.Drawing.Point(84, 384);
            this.txtNomeevt.Name = "txtNomeevt";
            this.txtNomeevt.Size = new System.Drawing.Size(257, 26);
            this.txtNomeevt.TabIndex = 130;
            this.txtNomeevt.Text = "Nome do Evento";
            // 
            // dgEventos
            // 
            this.dgEventos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEventos.Location = new System.Drawing.Point(190, 195);
            this.dgEventos.Name = "dgEventos";
            this.dgEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEventos.Size = new System.Drawing.Size(669, 220);
            this.dgEventos.TabIndex = 129;
            this.dgEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEventos_CellClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_carregar;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(561, 467);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(143, 62);
            this.btnCadastrar.TabIndex = 135;
            this.btnCadastrar.Text = "Atualizar Dados";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(544, 163);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(185, 26);
            this.txtId.TabIndex = 136;
            this.txtId.Text = "ID\r\n";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::Chamadaa.Properties.Resources.btn_excluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(757, 163);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 29);
            this.btnExcluir.TabIndex = 137;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Chamadaa.Properties.Resources.X;
            this.pictureBox2.Location = new System.Drawing.Point(1010, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 412;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(148, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 414;
            this.label3.Text = "Formulário: Eventos\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 413;
            this.label2.Text = "Sessão: CD";
            // 
            // CDEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chamadaa.Properties.Resources.Fundo_controles;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 633);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtModalidade);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtOrganizador);
            this.Controls.Add(this.txtNomeevt);
            this.Controls.Add(this.dgEventos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CDEventos";
            this.Text = "CDEventos";
            this.Load += new System.EventHandler(this.CDEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtOrganizador;
        private System.Windows.Forms.TextBox txtNomeevt;
        public System.Windows.Forms.DataGridView dgEventos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}