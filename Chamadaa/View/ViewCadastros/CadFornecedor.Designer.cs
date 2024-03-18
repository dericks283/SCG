namespace Chamadaa.View.ViewCadastros
{
    partial class CadFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFornecedor));
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.txtIdentificacaoForn = new System.Windows.Forms.TextBox();
            this.txtEndFornecedor = new System.Windows.Forms.TextBox();
            this.txtEmailFor = new System.Windows.Forms.TextBox();
            this.txtTelFor = new System.Windows.Forms.TextBox();
            this.txtNomeFor = new System.Windows.Forms.TextBox();
            this.txtFornCel = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCadastFornecedor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.AllowUserToResizeRows = false;
            this.dgvFornecedor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvFornecedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvFornecedor.Location = new System.Drawing.Point(47, 305);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(522, 207);
            this.dgvFornecedor.TabIndex = 94;
            // 
            // txtIdentificacaoForn
            // 
            this.txtIdentificacaoForn.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtIdentificacaoForn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentificacaoForn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtIdentificacaoForn.ForeColor = System.Drawing.Color.Silver;
            this.txtIdentificacaoForn.Location = new System.Drawing.Point(382, 229);
            this.txtIdentificacaoForn.MaxLength = 14;
            this.txtIdentificacaoForn.Name = "txtIdentificacaoForn";
            this.txtIdentificacaoForn.Size = new System.Drawing.Size(312, 23);
            this.txtIdentificacaoForn.TabIndex = 93;
            this.txtIdentificacaoForn.Text = "CPF/CNPJ";
            this.txtIdentificacaoForn.Enter += new System.EventHandler(this.txtIdentificacaoForn_Enter);
            this.txtIdentificacaoForn.Leave += new System.EventHandler(this.txtIdentificacaoForn_Leave);
            // 
            // txtEndFornecedor
            // 
            this.txtEndFornecedor.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtEndFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndFornecedor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtEndFornecedor.ForeColor = System.Drawing.Color.Silver;
            this.txtEndFornecedor.Location = new System.Drawing.Point(382, 277);
            this.txtEndFornecedor.Name = "txtEndFornecedor";
            this.txtEndFornecedor.Size = new System.Drawing.Size(263, 23);
            this.txtEndFornecedor.TabIndex = 92;
            this.txtEndFornecedor.Text = "Endereço";
            this.txtEndFornecedor.Enter += new System.EventHandler(this.txtEndFornecedor_Enter);
            this.txtEndFornecedor.Leave += new System.EventHandler(this.txtEndFornecedor_Leave);
            // 
            // txtEmailFor
            // 
            this.txtEmailFor.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtEmailFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailFor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtEmailFor.ForeColor = System.Drawing.Color.Silver;
            this.txtEmailFor.Location = new System.Drawing.Point(575, 331);
            this.txtEmailFor.Name = "txtEmailFor";
            this.txtEmailFor.Size = new System.Drawing.Size(252, 23);
            this.txtEmailFor.TabIndex = 90;
            this.txtEmailFor.Text = "Email*";
            this.txtEmailFor.Enter += new System.EventHandler(this.txtEmailFor_Enter);
            this.txtEmailFor.Leave += new System.EventHandler(this.txtEmailFor_Leave);
            // 
            // txtTelFor
            // 
            this.txtTelFor.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtTelFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelFor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtTelFor.ForeColor = System.Drawing.Color.Silver;
            this.txtTelFor.Location = new System.Drawing.Point(575, 416);
            this.txtTelFor.MaxLength = 12;
            this.txtTelFor.Name = "txtTelFor";
            this.txtTelFor.Size = new System.Drawing.Size(178, 23);
            this.txtTelFor.TabIndex = 89;
            this.txtTelFor.Text = "Telefone";
            this.txtTelFor.Enter += new System.EventHandler(this.txtTelFor_Enter);
            this.txtTelFor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelFor_KeyPress);
            this.txtTelFor.Leave += new System.EventHandler(this.txtTelFor_Leave);
            // 
            // txtNomeFor
            // 
            this.txtNomeFor.BackColor = System.Drawing.Color.Black;
            this.txtNomeFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtNomeFor.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeFor.HideSelection = false;
            this.txtNomeFor.Location = new System.Drawing.Point(382, 174);
            this.txtNomeFor.Name = "txtNomeFor";
            this.txtNomeFor.Size = new System.Drawing.Size(411, 23);
            this.txtNomeFor.TabIndex = 88;
            this.txtNomeFor.Text = "Nome*";
            this.txtNomeFor.Enter += new System.EventHandler(this.txtNomeFor_Enter);
            this.txtNomeFor.Leave += new System.EventHandler(this.txtNomeFor_Leave);
            // 
            // txtFornCel
            // 
            this.txtFornCel.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtFornCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFornCel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtFornCel.ForeColor = System.Drawing.Color.Silver;
            this.txtFornCel.Location = new System.Drawing.Point(575, 375);
            this.txtFornCel.MaxLength = 13;
            this.txtFornCel.Name = "txtFornCel";
            this.txtFornCel.Size = new System.Drawing.Size(178, 23);
            this.txtFornCel.TabIndex = 95;
            this.txtFornCel.Text = "Celular";
            this.txtFornCel.TextChanged += new System.EventHandler(this.txtFornCel_TextChanged);
            this.txtFornCel.Enter += new System.EventHandler(this.txtFornCel_Enter);
            this.txtFornCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFornCel_KeyPress);
            this.txtFornCel.Leave += new System.EventHandler(this.txtFornCel_Leave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Silver;
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnReset.Location = new System.Drawing.Point(47, 274);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 96;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCadastFornecedor
            // 
            this.btnCadastFornecedor.BackgroundImage = global::Chamadaa.Properties.Resources.btn_cadastrar;
            this.btnCadastFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastFornecedor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnCadastFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastFornecedor.Location = new System.Drawing.Point(585, 444);
            this.btnCadastFornecedor.Name = "btnCadastFornecedor";
            this.btnCadastFornecedor.Size = new System.Drawing.Size(168, 54);
            this.btnCadastFornecedor.TabIndex = 91;
            this.btnCadastFornecedor.Text = "Cadastrar";
            this.btnCadastFornecedor.UseVisualStyleBackColor = true;
            this.btnCadastFornecedor.Click += new System.EventHandler(this.btnCadastFornecedor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Chamadaa.Properties.Resources.fundo_cad_Fornecedores;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(869, 474);
            this.pictureBox1.TabIndex = 117;
            this.pictureBox1.TabStop = false;
            // 
            // CadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtFornCel);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.txtIdentificacaoForn);
            this.Controls.Add(this.txtEndFornecedor);
            this.Controls.Add(this.btnCadastFornecedor);
            this.Controls.Add(this.txtEmailFor);
            this.Controls.Add(this.txtTelFor);
            this.Controls.Add(this.txtNomeFor);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadFornecedor";
            this.Text = "CadFornecedor";
            this.Load += new System.EventHandler(this.CadFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.TextBox txtIdentificacaoForn;
        private System.Windows.Forms.TextBox txtEndFornecedor;
        private System.Windows.Forms.Button btnCadastFornecedor;
        private System.Windows.Forms.TextBox txtEmailFor;
        private System.Windows.Forms.TextBox txtTelFor;
        private System.Windows.Forms.TextBox txtNomeFor;
        private System.Windows.Forms.TextBox txtFornCel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}