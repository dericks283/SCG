namespace Chamadaa.View.ViewDC
{
    partial class DCAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DCAluno));
            this.dgAlunos = new System.Windows.Forms.DataGridView();
            this.txtNomeAlu = new System.Windows.Forms.TextBox();
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlunos
            // 
            this.dgAlunos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlunos.Location = new System.Drawing.Point(164, 228);
            this.dgAlunos.Name = "dgAlunos";
            this.dgAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAlunos.Size = new System.Drawing.Size(728, 278);
            this.dgAlunos.TabIndex = 0;
            this.dgAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlunos_CellContentClick);
            this.dgAlunos.Click += new System.EventHandler(this.dgAlunos_Click);
            this.dgAlunos.DoubleClick += new System.EventHandler(this.dgAlunos_DoubleClick);
            // 
            // txtNomeAlu
            // 
            this.txtNomeAlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeAlu.BackColor = System.Drawing.Color.Black;
            this.txtNomeAlu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAlu.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeAlu.Location = new System.Drawing.Point(164, 196);
            this.txtNomeAlu.Name = "txtNomeAlu";
            this.txtNomeAlu.Size = new System.Drawing.Size(216, 26);
            this.txtNomeAlu.TabIndex = 4;
            this.txtNomeAlu.Text = "Nome do Aluno*:";
            this.txtNomeAlu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNomeAlu.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtNomeAlu.Leave += new System.EventHandler(this.textBox1_Leave);
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
            "Volei",
            "Futsal",
            "Handebol",
            "Natacao"});
            this.cbModalidade.Location = new System.Drawing.Point(491, 196);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(159, 26);
            this.cbModalidade.TabIndex = 6;
            this.cbModalidade.Text = "Modalidade";
            this.cbModalidade.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackgroundImage = global::Chamadaa.Properties.Resources.btn_Pesquisar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(767, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(172, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 120;
            this.label3.Text = "Formulário: Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 119;
            this.label2.Text = "Sessão: CD";
            // 
            // DCAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Chamadaa.Properties.Resources.Fundo_controles;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbModalidade);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNomeAlu);
            this.Controls.Add(this.dgAlunos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DCAluno";
            this.Text = "DCAluno";
            this.Load += new System.EventHandler(this.DCAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeAlu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbModalidade;
        public System.Windows.Forms.DataGridView dgAlunos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}