namespace Chamadaa.View.ViewDC
{
    partial class DCProduto
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
            this.dgvEquipamentos = new System.Windows.Forms.DataGridView();
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
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.txtEquipamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipamentos
            // 
            this.dgvEquipamentos.AllowUserToAddRows = false;
            this.dgvEquipamentos.AllowUserToDeleteRows = false;
            this.dgvEquipamentos.AllowUserToResizeRows = false;
            this.dgvEquipamentos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvEquipamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvEquipamentos.Location = new System.Drawing.Point(12, 222);
            this.dgvEquipamentos.Name = "dgvEquipamentos";
            this.dgvEquipamentos.Size = new System.Drawing.Size(636, 228);
            this.dgvEquipamentos.TabIndex = 99;
            this.dgvEquipamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipamentos_CellClick);
            this.dgvEquipamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipamentos_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 129;
            this.label6.Text = "Data da ultima verificação:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 128;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "Data da inserção no estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 126;
            this.label3.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 125;
            this.label1.Text = "Nome do Produto";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(15, 173);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(144, 43);
            this.btnAtualizar.TabIndex = 124;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtnomeProduto
            // 
            this.txtnomeProduto.BackColor = System.Drawing.Color.White;
            this.txtnomeProduto.ForeColor = System.Drawing.Color.Blue;
            this.txtnomeProduto.Location = new System.Drawing.Point(12, 24);
            this.txtnomeProduto.Name = "txtnomeProduto";
            this.txtnomeProduto.Size = new System.Drawing.Size(294, 20);
            this.txtnomeProduto.TabIndex = 123;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.BackColor = System.Drawing.Color.White;
            this.cbFornecedor.ForeColor = System.Drawing.Color.Blue;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Items.AddRange(new object[] {
            "OK",
            "Necessita reposição"});
            this.cbFornecedor.Location = new System.Drawing.Point(515, 67);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(133, 21);
            this.cbFornecedor.TabIndex = 122;
            this.cbFornecedor.Text = "Fornecedores";
            // 
            // txtDataVerificação
            // 
            this.txtDataVerificação.BackColor = System.Drawing.Color.White;
            this.txtDataVerificação.ForeColor = System.Drawing.Color.Blue;
            this.txtDataVerificação.Location = new System.Drawing.Point(461, 115);
            this.txtDataVerificação.Name = "txtDataVerificação";
            this.txtDataVerificação.Size = new System.Drawing.Size(187, 20);
            this.txtDataVerificação.TabIndex = 121;
            this.txtDataVerificação.Text = "\r\n";
            this.txtDataVerificação.TextChanged += new System.EventHandler(this.txtDataVerificação_TextChanged);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.White;
            this.txtTipo.ForeColor = System.Drawing.Color.Blue;
            this.txtTipo.Location = new System.Drawing.Point(12, 68);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(239, 20);
            this.txtTipo.TabIndex = 120;
            // 
            // txtDataInserção
            // 
            this.txtDataInserção.BackColor = System.Drawing.Color.White;
            this.txtDataInserção.ForeColor = System.Drawing.Color.Blue;
            this.txtDataInserção.Location = new System.Drawing.Point(12, 112);
            this.txtDataInserção.Name = "txtDataInserção";
            this.txtDataInserção.Size = new System.Drawing.Size(147, 20);
            this.txtDataInserção.TabIndex = 119;
            // 
            // txtDescriçãoProduto
            // 
            this.txtDescriçãoProduto.BackColor = System.Drawing.Color.White;
            this.txtDescriçãoProduto.ForeColor = System.Drawing.Color.Blue;
            this.txtDescriçãoProduto.Location = new System.Drawing.Point(409, 24);
            this.txtDescriçãoProduto.Name = "txtDescriçãoProduto";
            this.txtDescriçãoProduto.Size = new System.Drawing.Size(239, 20);
            this.txtDescriçãoProduto.TabIndex = 118;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.BackColor = System.Drawing.Color.White;
            this.txtIdProduto.Enabled = false;
            this.txtIdProduto.ForeColor = System.Drawing.Color.Blue;
            this.txtIdProduto.Location = new System.Drawing.Point(420, 183);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(112, 20);
            this.txtIdProduto.TabIndex = 117;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(561, 183);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 116;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.White;
            this.txtStatus.Enabled = false;
            this.txtStatus.ForeColor = System.Drawing.Color.Blue;
            this.txtStatus.Location = new System.Drawing.Point(396, 469);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(162, 20);
            this.txtStatus.TabIndex = 132;
            this.txtStatus.Text = "Status:";
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(573, 466);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(75, 23);
            this.btnIr.TabIndex = 131;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // txtEquipamento
            // 
            this.txtEquipamento.BackColor = System.Drawing.Color.White;
            this.txtEquipamento.Enabled = false;
            this.txtEquipamento.ForeColor = System.Drawing.Color.Blue;
            this.txtEquipamento.Location = new System.Drawing.Point(12, 469);
            this.txtEquipamento.Name = "txtEquipamento";
            this.txtEquipamento.Size = new System.Drawing.Size(303, 20);
            this.txtEquipamento.TabIndex = 130;
            this.txtEquipamento.Text = "Componente:";
            // 
            // DCProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 528);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.txtEquipamento);
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
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvEquipamentos);
            this.Name = "DCProduto";
            this.Text = "DCProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquipamentos;
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
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.TextBox txtEquipamento;
    }
}