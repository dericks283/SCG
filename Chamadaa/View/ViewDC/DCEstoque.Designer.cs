namespace Chamadaa.View.ViewDC
{
    partial class DCEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DCEstoque));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtnomeProduto = new System.Windows.Forms.TextBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtDataVerificação = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtDataInserção = new System.Windows.Forms.TextBox();
            this.txtDescriçãoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvEquipamentos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(665, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 131;
            this.label6.Text = "Data da ultima verificação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 130;
            this.label5.Text = "Descrição:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 129;
            this.label4.Text = "Data da inserção no estoque";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 128;
            this.label3.Text = "Tipo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 127;
            this.label1.Text = "Nome do Produto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_carregar;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtualizar.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(710, 499);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(144, 43);
            this.btnAtualizar.TabIndex = 126;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtnomeProduto
            // 
            this.txtnomeProduto.BackColor = System.Drawing.Color.Black;
            this.txtnomeProduto.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtnomeProduto.ForeColor = System.Drawing.Color.Silver;
            this.txtnomeProduto.Location = new System.Drawing.Point(643, 165);
            this.txtnomeProduto.Name = "txtnomeProduto";
            this.txtnomeProduto.Size = new System.Drawing.Size(211, 23);
            this.txtnomeProduto.TabIndex = 125;
            this.txtnomeProduto.TextChanged += new System.EventHandler(this.txtnomeProduto_TextChanged);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.BackColor = System.Drawing.Color.Black;
            this.cbFornecedor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.cbFornecedor.ForeColor = System.Drawing.Color.Silver;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Items.AddRange(new object[] {
            "OK",
            "Necessita reposição"});
            this.cbFornecedor.Location = new System.Drawing.Point(646, 386);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(133, 23);
            this.cbFornecedor.TabIndex = 124;
            this.cbFornecedor.Text = "Fornecedores";
            // 
            // txtDataVerificação
            // 
            this.txtDataVerificação.BackColor = System.Drawing.Color.Black;
            this.txtDataVerificação.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtDataVerificação.ForeColor = System.Drawing.Color.Silver;
            this.txtDataVerificação.Location = new System.Drawing.Point(643, 448);
            this.txtDataVerificação.MaxLength = 10;
            this.txtDataVerificação.Name = "txtDataVerificação";
            this.txtDataVerificação.Size = new System.Drawing.Size(187, 23);
            this.txtDataVerificação.TabIndex = 123;
            this.txtDataVerificação.Text = "\r\n";
            this.txtDataVerificação.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataVerificação_KeyPress);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.Black;
            this.txtTipo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtTipo.ForeColor = System.Drawing.Color.Silver;
            this.txtTipo.Location = new System.Drawing.Point(643, 224);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(211, 23);
            this.txtTipo.TabIndex = 122;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            // 
            // txtDataInserção
            // 
            this.txtDataInserção.BackColor = System.Drawing.Color.Black;
            this.txtDataInserção.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtDataInserção.ForeColor = System.Drawing.Color.Silver;
            this.txtDataInserção.Location = new System.Drawing.Point(643, 286);
            this.txtDataInserção.MaxLength = 10;
            this.txtDataInserção.Name = "txtDataInserção";
            this.txtDataInserção.Size = new System.Drawing.Size(163, 23);
            this.txtDataInserção.TabIndex = 121;
            this.txtDataInserção.TextChanged += new System.EventHandler(this.txtDataInserção_TextChanged);
            this.txtDataInserção.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataInserção_KeyPress);
            // 
            // txtDescriçãoProduto
            // 
            this.txtDescriçãoProduto.BackColor = System.Drawing.Color.Black;
            this.txtDescriçãoProduto.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtDescriçãoProduto.ForeColor = System.Drawing.Color.Silver;
            this.txtDescriçãoProduto.Location = new System.Drawing.Point(643, 344);
            this.txtDescriçãoProduto.Name = "txtDescriçãoProduto";
            this.txtDescriçãoProduto.Size = new System.Drawing.Size(211, 23);
            this.txtDescriçãoProduto.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 119;
            this.label2.Text = "Identificação";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtIdProduto.Enabled = false;
            this.txtIdProduto.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtIdProduto.ForeColor = System.Drawing.Color.Silver;
            this.txtIdProduto.Location = new System.Drawing.Point(411, 150);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(112, 23);
            this.txtIdProduto.TabIndex = 118;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::Chamadaa.Properties.Resources.btn_excluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(534, 146);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 32);
            this.btnExcluir.TabIndex = 117;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvEquipamentos
            // 
            this.dgvEquipamentos.AllowUserToAddRows = false;
            this.dgvEquipamentos.AllowUserToDeleteRows = false;
            this.dgvEquipamentos.AllowUserToResizeRows = false;
            this.dgvEquipamentos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvEquipamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvEquipamentos.Location = new System.Drawing.Point(62, 179);
            this.dgvEquipamentos.Name = "dgvEquipamentos";
            this.dgvEquipamentos.Size = new System.Drawing.Size(563, 282);
            this.dgvEquipamentos.TabIndex = 116;
            this.dgvEquipamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipamentos_CellClick);
            this.dgvEquipamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipamentos_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(114, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 132;
            this.label7.Text = "Sessão: CD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(205, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 133;
            this.label8.Text = "Estoque";
            // 
            // DCEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chamadaa.Properties.Resources.Fundo_controles;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtnomeProduto);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.txtDataVerificação);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtDataInserção);
            this.Controls.Add(this.txtDescriçãoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvEquipamentos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DCEstoque";
            this.Text = "DCEstoque";
            this.Load += new System.EventHandler(this.DCEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtnomeProduto;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.TextBox txtDataVerificação;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtDataInserção;
        private System.Windows.Forms.TextBox txtDescriçãoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvEquipamentos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}