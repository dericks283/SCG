namespace Chamadaa.View.ViewCadastros
{
    partial class CadAlu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadAlu));
            this.cbProfessorAlu = new System.Windows.Forms.ComboBox();
            this.cbModalidadeAlu = new System.Windows.Forms.ComboBox();
            this.dgvModalidades = new System.Windows.Forms.DataGridView();
            this.txtEmailAlu = new System.Windows.Forms.TextBox();
            this.txtTelAlu = new System.Windows.Forms.TextBox();
            this.txtNomeAlu = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.txtCelularAlu = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProfessorAlu
            // 
            this.cbProfessorAlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbProfessorAlu.BackColor = System.Drawing.Color.Black;
            this.cbProfessorAlu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.cbProfessorAlu.ForeColor = System.Drawing.Color.Silver;
            this.cbProfessorAlu.FormattingEnabled = true;
            this.cbProfessorAlu.Location = new System.Drawing.Point(43, 486);
            this.cbProfessorAlu.Name = "cbProfessorAlu";
            this.cbProfessorAlu.Size = new System.Drawing.Size(154, 23);
            this.cbProfessorAlu.TabIndex = 99;
            this.cbProfessorAlu.Text = "Professor*";
            // 
            // cbModalidadeAlu
            // 
            this.cbModalidadeAlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbModalidadeAlu.BackColor = System.Drawing.Color.Black;
            this.cbModalidadeAlu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.cbModalidadeAlu.ForeColor = System.Drawing.Color.Silver;
            this.cbModalidadeAlu.FormattingEnabled = true;
            this.cbModalidadeAlu.Items.AddRange(new object[] {
            "Basquete",
            "Volei",
            "Futsal",
            "Handebol",
            "Natacao"});
            this.cbModalidadeAlu.Location = new System.Drawing.Point(292, 486);
            this.cbModalidadeAlu.Name = "cbModalidadeAlu";
            this.cbModalidadeAlu.Size = new System.Drawing.Size(154, 23);
            this.cbModalidadeAlu.TabIndex = 98;
            this.cbModalidadeAlu.Text = "Modalidade";
            this.cbModalidadeAlu.DropDown += new System.EventHandler(this.cbModalidadeAlu_DropDown);
            // 
            // dgvModalidades
            // 
            this.dgvModalidades.AllowUserToAddRows = false;
            this.dgvModalidades.AllowUserToDeleteRows = false;
            this.dgvModalidades.AllowUserToResizeRows = false;
            this.dgvModalidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvModalidades.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvModalidades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvModalidades.Location = new System.Drawing.Point(515, 157);
            this.dgvModalidades.Name = "dgvModalidades";
            this.dgvModalidades.Size = new System.Drawing.Size(493, 221);
            this.dgvModalidades.TabIndex = 97;
            this.dgvModalidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModalidades_CellClick);
            // 
            // txtEmailAlu
            // 
            this.txtEmailAlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailAlu.BackColor = System.Drawing.Color.Black;
            this.txtEmailAlu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailAlu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtEmailAlu.ForeColor = System.Drawing.Color.Silver;
            this.txtEmailAlu.Location = new System.Drawing.Point(233, 279);
            this.txtEmailAlu.Name = "txtEmailAlu";
            this.txtEmailAlu.Size = new System.Drawing.Size(237, 23);
            this.txtEmailAlu.TabIndex = 93;
            this.txtEmailAlu.Text = "Email*";
            this.txtEmailAlu.Enter += new System.EventHandler(this.txtEmailAlu_Enter);
            this.txtEmailAlu.Leave += new System.EventHandler(this.txtEmailAlu_Leave);
            // 
            // txtTelAlu
            // 
            this.txtTelAlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelAlu.BackColor = System.Drawing.Color.Black;
            this.txtTelAlu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelAlu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtTelAlu.ForeColor = System.Drawing.Color.Silver;
            this.txtTelAlu.Location = new System.Drawing.Point(45, 279);
            this.txtTelAlu.MaxLength = 12;
            this.txtTelAlu.Name = "txtTelAlu";
            this.txtTelAlu.Size = new System.Drawing.Size(182, 23);
            this.txtTelAlu.TabIndex = 92;
            this.txtTelAlu.Text = "Telefone";
            this.txtTelAlu.Enter += new System.EventHandler(this.txtTelAlu_Enter);
            this.txtTelAlu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelAlu_KeyPress);
            this.txtTelAlu.Leave += new System.EventHandler(this.txtTelAlu_Leave);
            // 
            // txtNomeAlu
            // 
            this.txtNomeAlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeAlu.BackColor = System.Drawing.Color.Black;
            this.txtNomeAlu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeAlu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtNomeAlu.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeAlu.HideSelection = false;
            this.txtNomeAlu.Location = new System.Drawing.Point(45, 238);
            this.txtNomeAlu.Name = "txtNomeAlu";
            this.txtNomeAlu.Size = new System.Drawing.Size(425, 23);
            this.txtNomeAlu.TabIndex = 91;
            this.txtNomeAlu.Text = "Nome*";
            this.txtNomeAlu.Enter += new System.EventHandler(this.txtNomeAlu_Enter);
            this.txtNomeAlu.Leave += new System.EventHandler(this.txtNomeAlu_Leave);
            // 
            // cbSexo
            // 
            this.cbSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSexo.BackColor = System.Drawing.Color.Black;
            this.cbSexo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.cbSexo.ForeColor = System.Drawing.Color.Silver;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(233, 323);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(154, 23);
            this.cbSexo.TabIndex = 100;
            this.cbSexo.Text = "Sexo*";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComplemento.BackColor = System.Drawing.Color.Black;
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtComplemento.ForeColor = System.Drawing.Color.Silver;
            this.txtComplemento.Location = new System.Drawing.Point(43, 416);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(276, 23);
            this.txtComplemento.TabIndex = 104;
            this.txtComplemento.Text = "Complemento";
            this.txtComplemento.Enter += new System.EventHandler(this.txtComplemento_Enter);
            this.txtComplemento.Leave += new System.EventHandler(this.txtComplemento_Leave);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEndereco.BackColor = System.Drawing.Color.Black;
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtEndereco.ForeColor = System.Drawing.Color.Silver;
            this.txtEndereco.Location = new System.Drawing.Point(43, 378);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(330, 23);
            this.txtEndereco.TabIndex = 105;
            this.txtEndereco.Text = "Endereço*";
            this.txtEndereco.Enter += new System.EventHandler(this.txtEndereco_Enter);
            this.txtEndereco.Leave += new System.EventHandler(this.txtEndereco_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = global::Chamadaa.Properties.Resources.btn_carregar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(322, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 45);
            this.button1.TabIndex = 107;
            this.button1.Text = "Consultar Turmas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtId.Location = new System.Drawing.Point(515, 404);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(40, 23);
            this.txtId.TabIndex = 108;
            this.txtId.Text = "ID";
            // 
            // txtTurma
            // 
            this.txtTurma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTurma.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtTurma.Location = new System.Drawing.Point(563, 403);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.ReadOnly = true;
            this.txtTurma.Size = new System.Drawing.Size(122, 23);
            this.txtTurma.TabIndex = 109;
            this.txtTurma.Text = "Turma*";
            // 
            // txtCelularAlu
            // 
            this.txtCelularAlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCelularAlu.BackColor = System.Drawing.Color.Black;
            this.txtCelularAlu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelularAlu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtCelularAlu.ForeColor = System.Drawing.Color.Silver;
            this.txtCelularAlu.Location = new System.Drawing.Point(45, 324);
            this.txtCelularAlu.MaxLength = 13;
            this.txtCelularAlu.Name = "txtCelularAlu";
            this.txtCelularAlu.Size = new System.Drawing.Size(182, 23);
            this.txtCelularAlu.TabIndex = 110;
            this.txtCelularAlu.Text = "Celular*";
            this.txtCelularAlu.Enter += new System.EventHandler(this.txtCelularAlu_Enter);
            this.txtCelularAlu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelularAlu_KeyPress);
            this.txtCelularAlu.Leave += new System.EventHandler(this.txtCelularAlu_Leave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Silver;
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnReset.Location = new System.Drawing.Point(933, 128);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 113;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_cadastrar;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrar.Location = new System.Drawing.Point(842, 384);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(166, 57);
            this.btnCadastrar.TabIndex = 101;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(270, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 115;
            this.label3.Text = "Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 114;
            this.label2.Text = "Sessão: Cadastros";
            // 
            // CadAlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Chamadaa.Properties.Resources.fundo_cad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtCelularAlu);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.cbProfessorAlu);
            this.Controls.Add(this.cbModalidadeAlu);
            this.Controls.Add(this.dgvModalidades);
            this.Controls.Add(this.txtEmailAlu);
            this.Controls.Add(this.txtTelAlu);
            this.Controls.Add(this.txtNomeAlu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadAlu";
            this.Load += new System.EventHandler(this.CadModaAlu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbProfessorAlu;
        private System.Windows.Forms.ComboBox cbModalidadeAlu;
        private System.Windows.Forms.DataGridView dgvModalidades;
        private System.Windows.Forms.TextBox txtEmailAlu;
        private System.Windows.Forms.TextBox txtTelAlu;
        private System.Windows.Forms.TextBox txtNomeAlu;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.TextBox txtCelularAlu;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}