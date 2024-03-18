namespace Chamadaa.View.ViewDC
{
    partial class DCFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DCFornecedor));
            this.txtIdFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFornecedor = new System.Windows.Forms.DataGridView();
            this.txtIdentificacaoForn = new System.Windows.Forms.TextBox();
            this.txtEndFornecedor = new System.Windows.Forms.TextBox();
            this.txtEmailFor = new System.Windows.Forms.TextBox();
            this.txtTelFor = new System.Windows.Forms.TextBox();
            this.txtNomeFor = new System.Windows.Forms.TextBox();
            this.txtCelForn = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdFornecedor
            // 
            this.txtIdFornecedor.BackColor = System.Drawing.Color.Black;
            this.txtIdFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdFornecedor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtIdFornecedor.ForeColor = System.Drawing.Color.Silver;
            this.txtIdFornecedor.HideSelection = false;
            this.txtIdFornecedor.Location = new System.Drawing.Point(514, 175);
            this.txtIdFornecedor.Name = "txtIdFornecedor";
            this.txtIdFornecedor.Size = new System.Drawing.Size(177, 23);
            this.txtIdFornecedor.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label1.Location = new System.Drawing.Point(421, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 104;
            this.label1.Text = "Identificação:";
            // 
            // dgvFornecedor
            // 
            this.dgvFornecedor.AllowUserToAddRows = false;
            this.dgvFornecedor.AllowUserToDeleteRows = false;
            this.dgvFornecedor.AllowUserToResizeRows = false;
            this.dgvFornecedor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvFornecedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvFornecedor.Location = new System.Drawing.Point(71, 204);
            this.dgvFornecedor.Name = "dgvFornecedor";
            this.dgvFornecedor.Size = new System.Drawing.Size(769, 214);
            this.dgvFornecedor.TabIndex = 103;
            this.dgvFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFornecedor_CellClick);
            // 
            // txtIdentificacaoForn
            // 
            this.txtIdentificacaoForn.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtIdentificacaoForn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentificacaoForn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtIdentificacaoForn.ForeColor = System.Drawing.Color.Silver;
            this.txtIdentificacaoForn.Location = new System.Drawing.Point(582, 480);
            this.txtIdentificacaoForn.Name = "txtIdentificacaoForn";
            this.txtIdentificacaoForn.Size = new System.Drawing.Size(258, 23);
            this.txtIdentificacaoForn.TabIndex = 102;
            // 
            // txtEndFornecedor
            // 
            this.txtEndFornecedor.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtEndFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndFornecedor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtEndFornecedor.ForeColor = System.Drawing.Color.Silver;
            this.txtEndFornecedor.Location = new System.Drawing.Point(71, 480);
            this.txtEndFornecedor.Name = "txtEndFornecedor";
            this.txtEndFornecedor.Size = new System.Drawing.Size(257, 23);
            this.txtEndFornecedor.TabIndex = 101;
            // 
            // txtEmailFor
            // 
            this.txtEmailFor.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtEmailFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailFor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtEmailFor.ForeColor = System.Drawing.Color.Silver;
            this.txtEmailFor.Location = new System.Drawing.Point(582, 438);
            this.txtEmailFor.Name = "txtEmailFor";
            this.txtEmailFor.Size = new System.Drawing.Size(258, 23);
            this.txtEmailFor.TabIndex = 100;
            // 
            // txtTelFor
            // 
            this.txtTelFor.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtTelFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelFor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtTelFor.ForeColor = System.Drawing.Color.Silver;
            this.txtTelFor.Location = new System.Drawing.Point(147, 524);
            this.txtTelFor.MaxLength = 12;
            this.txtTelFor.Name = "txtTelFor";
            this.txtTelFor.Size = new System.Drawing.Size(181, 23);
            this.txtTelFor.TabIndex = 99;
            // 
            // txtNomeFor
            // 
            this.txtNomeFor.BackColor = System.Drawing.Color.Black;
            this.txtNomeFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtNomeFor.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeFor.HideSelection = false;
            this.txtNomeFor.Location = new System.Drawing.Point(71, 438);
            this.txtNomeFor.Name = "txtNomeFor";
            this.txtNomeFor.Size = new System.Drawing.Size(373, 23);
            this.txtNomeFor.TabIndex = 98;
            // 
            // txtCelForn
            // 
            this.txtCelForn.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtCelForn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelForn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtCelForn.ForeColor = System.Drawing.Color.Silver;
            this.txtCelForn.Location = new System.Drawing.Point(706, 524);
            this.txtCelForn.MaxLength = 13;
            this.txtCelForn.Name = "txtCelForn";
            this.txtCelForn.Size = new System.Drawing.Size(134, 23);
            this.txtCelForn.TabIndex = 108;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::Chamadaa.Properties.Resources.btn_excluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(694, 169);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 29);
            this.btnExcluir.TabIndex = 106;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_carregar;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(439, 534);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(171, 54);
            this.btnAtualizar.TabIndex = 105;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label2.Location = new System.Drawing.Point(579, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Email*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label3.Location = new System.Drawing.Point(579, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 111;
            this.label3.Text = "CPF/CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label4.Location = new System.Drawing.Point(144, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 112;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label5.Location = new System.Drawing.Point(68, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 113;
            this.label5.Text = "Endereço*:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label6.Location = new System.Drawing.Point(68, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 114;
            this.label6.Text = "Nome*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.label7.Location = new System.Drawing.Point(783, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 115;
            this.label7.Text = "Celular*:";
            // 
            // DCFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chamadaa.Properties.Resources.Fundo_controles;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCelForn);
            this.Controls.Add(this.txtIdFornecedor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFornecedor);
            this.Controls.Add(this.txtIdentificacaoForn);
            this.Controls.Add(this.txtEndFornecedor);
            this.Controls.Add(this.txtEmailFor);
            this.Controls.Add(this.txtTelFor);
            this.Controls.Add(this.txtNomeFor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DCFornecedor";
            this.Text = "DCFornecedor";
            this.Load += new System.EventHandler(this.DCFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdFornecedor;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFornecedor;
        private System.Windows.Forms.TextBox txtIdentificacaoForn;
        private System.Windows.Forms.TextBox txtEndFornecedor;
        private System.Windows.Forms.TextBox txtEmailFor;
        private System.Windows.Forms.TextBox txtTelFor;
        private System.Windows.Forms.TextBox txtNomeFor;
        private System.Windows.Forms.TextBox txtCelForn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}