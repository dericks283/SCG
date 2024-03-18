namespace Chamadaa.View.ViewCadastros
{
    partial class CadEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadEstoque));
            this.txtnomeProduto = new System.Windows.Forms.TextBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtDataVerificação = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtDataInserção = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.txtDescriçãoProduto = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnomeProduto
            // 
            this.txtnomeProduto.BackColor = System.Drawing.Color.Black;
            this.txtnomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomeProduto.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtnomeProduto.ForeColor = System.Drawing.Color.Silver;
            this.txtnomeProduto.Location = new System.Drawing.Point(326, 173);
            this.txtnomeProduto.Name = "txtnomeProduto";
            this.txtnomeProduto.Size = new System.Drawing.Size(227, 23);
            this.txtnomeProduto.TabIndex = 111;
            this.txtnomeProduto.Text = "Produto:";
            this.txtnomeProduto.Enter += new System.EventHandler(this.txtnomeProduto_Enter);
            this.txtnomeProduto.Leave += new System.EventHandler(this.txtnomeProduto_Leave);
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.BackColor = System.Drawing.Color.Black;
            this.cbFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFornecedor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.cbFornecedor.ForeColor = System.Drawing.Color.Silver;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Items.AddRange(new object[] {
            "OK",
            "Necessita reposição"});
            this.cbFornecedor.Location = new System.Drawing.Point(720, 262);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(133, 23);
            this.cbFornecedor.TabIndex = 110;
            this.cbFornecedor.Text = "Fornecedor";
            // 
            // txtDataVerificação
            // 
            this.txtDataVerificação.BackColor = System.Drawing.Color.Black;
            this.txtDataVerificação.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataVerificação.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtDataVerificação.ForeColor = System.Drawing.Color.Silver;
            this.txtDataVerificação.Location = new System.Drawing.Point(642, 323);
            this.txtDataVerificação.MaxLength = 10;
            this.txtDataVerificação.Name = "txtDataVerificação";
            this.txtDataVerificação.Size = new System.Drawing.Size(211, 23);
            this.txtDataVerificação.TabIndex = 109;
            this.txtDataVerificação.Text = "Data da ultima verificação:";
            this.txtDataVerificação.Enter += new System.EventHandler(this.txtDataVerificação_Enter);
            this.txtDataVerificação.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataVerificação_KeyPress);
            this.txtDataVerificação.Leave += new System.EventHandler(this.txtDataVerificação_Leave);
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.Black;
            this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtTipo.ForeColor = System.Drawing.Color.Silver;
            this.txtTipo.Location = new System.Drawing.Point(326, 218);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(239, 23);
            this.txtTipo.TabIndex = 108;
            this.txtTipo.Text = "Tipo:";
            this.txtTipo.Enter += new System.EventHandler(this.txtTipo_Enter);
            this.txtTipo.Leave += new System.EventHandler(this.txtTipo_Leave);
            // 
            // txtDataInserção
            // 
            this.txtDataInserção.BackColor = System.Drawing.Color.Black;
            this.txtDataInserção.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataInserção.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtDataInserção.ForeColor = System.Drawing.Color.Silver;
            this.txtDataInserção.Location = new System.Drawing.Point(642, 218);
            this.txtDataInserção.MaxLength = 10;
            this.txtDataInserção.Name = "txtDataInserção";
            this.txtDataInserção.Size = new System.Drawing.Size(211, 23);
            this.txtDataInserção.TabIndex = 107;
            this.txtDataInserção.Text = "Data de inserção no estoque:";
            this.txtDataInserção.Enter += new System.EventHandler(this.txtDataInserção_Enter);
            this.txtDataInserção.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataInserção_KeyPress_1);
            this.txtDataInserção.Leave += new System.EventHandler(this.txtDataInserção_Leave);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.GridColor = System.Drawing.Color.Black;
            this.dgvProdutos.Location = new System.Drawing.Point(47, 260);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(570, 238);
            this.dgvProdutos.TabIndex = 106;
            // 
            // txtDescriçãoProduto
            // 
            this.txtDescriçãoProduto.BackColor = System.Drawing.Color.Black;
            this.txtDescriçãoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescriçãoProduto.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtDescriçãoProduto.ForeColor = System.Drawing.Color.Silver;
            this.txtDescriçãoProduto.Location = new System.Drawing.Point(559, 173);
            this.txtDescriçãoProduto.Name = "txtDescriçãoProduto";
            this.txtDescriçãoProduto.Size = new System.Drawing.Size(294, 23);
            this.txtDescriçãoProduto.TabIndex = 104;
            this.txtDescriçãoProduto.Text = "Descrição:";
            this.txtDescriçãoProduto.Enter += new System.EventHandler(this.txtDescriçãoProduto_Enter);
            this.txtDescriçãoProduto.Leave += new System.EventHandler(this.txtDescriçãoProduto_Leave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Silver;
            this.btnReset.Enabled = false;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(623, 475);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 112;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_cadastrar;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrar.Location = new System.Drawing.Point(665, 393);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(154, 44);
            this.btnCadastrar.TabIndex = 105;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Chamadaa.Properties.Resources.fundo_cad_Estoque;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(876, 474);
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // CadEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtnomeProduto);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.txtDataVerificação);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtDataInserção);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtDescriçãoProduto);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadEstoque";
            this.Text = "CadEstoque";
            this.Load += new System.EventHandler(this.CadEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnomeProduto;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.TextBox txtDataVerificação;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtDataInserção;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtDescriçãoProduto;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}