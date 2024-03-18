namespace Chamadaa.View.View_Eventos
{
    partial class Tela_evts_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_evts_principal));
            this.dgEventos = new System.Windows.Forms.DataGridView();
            this.txtNomeevt = new System.Windows.Forms.TextBox();
            this.txtOrganizador = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtModalidade = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCamp = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEventos
            // 
            this.dgEventos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEventos.Location = new System.Drawing.Point(215, 347);
            this.dgEventos.Name = "dgEventos";
            this.dgEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEventos.Size = new System.Drawing.Size(525, 220);
            this.dgEventos.TabIndex = 8;
            this.dgEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEventos_CellClick);
            this.dgEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEventos_CellContentClick);
            this.dgEventos.DoubleClick += new System.EventHandler(this.dgEventos_DoubleClick);
            // 
            // txtNomeevt
            // 
            this.txtNomeevt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNomeevt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeevt.Location = new System.Drawing.Point(130, 143);
            this.txtNomeevt.Name = "txtNomeevt";
            this.txtNomeevt.Size = new System.Drawing.Size(280, 26);
            this.txtNomeevt.TabIndex = 10;
            // 
            // txtOrganizador
            // 
            this.txtOrganizador.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtOrganizador.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizador.Location = new System.Drawing.Point(278, 230);
            this.txtOrganizador.Name = "txtOrganizador";
            this.txtOrganizador.Size = new System.Drawing.Size(132, 26);
            this.txtOrganizador.TabIndex = 11;
            this.txtOrganizador.Text = "Organizador";
            this.txtOrganizador.Enter += new System.EventHandler(this.txtOrganizador_Enter);
            this.txtOrganizador.Leave += new System.EventHandler(this.txtOrganizador_Leave);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtData.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(130, 286);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(280, 26);
            this.txtData.TabIndex = 12;
            this.txtData.Text = "Data";
            this.txtData.Enter += new System.EventHandler(this.txtData_Enter);
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtData_KeyPress);
            this.txtData.Leave += new System.EventHandler(this.txtData_Leave);
            // 
            // txtLocal
            // 
            this.txtLocal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtLocal.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocal.Location = new System.Drawing.Point(130, 179);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(159, 26);
            this.txtLocal.TabIndex = 13;
            this.txtLocal.Text = "Local";
            this.txtLocal.Enter += new System.EventHandler(this.txtLocal_Enter);
            this.txtLocal.Leave += new System.EventHandler(this.txtLocal_Leave);
            // 
            // txtModalidade
            // 
            this.txtModalidade.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtModalidade.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModalidade.Location = new System.Drawing.Point(130, 230);
            this.txtModalidade.Name = "txtModalidade";
            this.txtModalidade.Size = new System.Drawing.Size(132, 26);
            this.txtModalidade.TabIndex = 14;
            this.txtModalidade.Text = "Modalidade";
            this.txtModalidade.Enter += new System.EventHandler(this.txtModalidade_Enter);
            this.txtModalidade.Leave += new System.EventHandler(this.txtModalidade_Leave);
            // 
            // btnIr
            // 
            this.btnIr.BackgroundImage = global::Chamadaa.Properties.Resources.btn_Pesquisar;
            this.btnIr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIr.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIr.Location = new System.Drawing.Point(617, 123);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(140, 63);
            this.btnIr.TabIndex = 16;
            this.btnIr.Text = "Procurar alunos";
            this.btnIr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 128;
            this.label1.Text = "Nome do Evento";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Chamadaa.Properties.Resources.btn_finalistas;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(617, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "Finalistas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCamp
            // 
            this.btnCamp.BackgroundImage = global::Chamadaa.Properties.Resources.btn_Camp;
            this.btnCamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCamp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamp.Location = new System.Drawing.Point(617, 197);
            this.btnCamp.Name = "btnCamp";
            this.btnCamp.Size = new System.Drawing.Size(140, 59);
            this.btnCamp.TabIndex = 17;
            this.btnCamp.Text = "Campeonato";
            this.btnCamp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamp.UseVisualStyleBackColor = true;
            this.btnCamp.Click += new System.EventHandler(this.btnCamp_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_cadastrar;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(445, 254);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(143, 62);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar Evento";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 570);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 129;
            this.label2.Text = "Exibição limpa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(413, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 17);
            this.label3.TabIndex = 130;
            this.label3.Text = "Duplo clique na tabela para ver detalhes";
            // 
            // Tela_evts_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chamadaa.Properties.Resources.fundo_tela_evt_principal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCamp);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.txtModalidade);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtOrganizador);
            this.Controls.Add(this.txtNomeevt);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_evts_principal";
            this.Text = "77";
            this.Load += new System.EventHandler(this.Tela_evts_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgEventos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeevt;
        private System.Windows.Forms.TextBox txtOrganizador;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtModalidade;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnCamp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}