namespace Chamadaa.View.ViewDC
{
    partial class DCProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DCProfessor));
            this.cbModalidade = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.dgProfessor = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // cbModalidade
            // 
            this.cbModalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbModalidade.BackColor = System.Drawing.Color.Black;
            this.cbModalidade.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModalidade.ForeColor = System.Drawing.Color.Gray;
            this.cbModalidade.FormattingEnabled = true;
            this.cbModalidade.Items.AddRange(new object[] {
            "Basquete",
            "Volei",
            "Futsal",
            "Handebol",
            "Natacao"});
            this.cbModalidade.Location = new System.Drawing.Point(540, 171);
            this.cbModalidade.Name = "cbModalidade";
            this.cbModalidade.Size = new System.Drawing.Size(161, 26);
            this.cbModalidade.TabIndex = 13;
            this.cbModalidade.Text = "Modalidade";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_Pesquisar;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Location = new System.Drawing.Point(725, 165);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(127, 37);
            this.btnPesquisar.TabIndex = 12;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeProf.BackColor = System.Drawing.Color.Black;
            this.txtNomeProf.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProf.ForeColor = System.Drawing.Color.Gray;
            this.txtNomeProf.Location = new System.Drawing.Point(231, 171);
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.Size = new System.Drawing.Size(291, 26);
            this.txtNomeProf.TabIndex = 11;
            this.txtNomeProf.Text = "Nome do Professor*:";
            this.txtNomeProf.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtNomeProf.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // dgProfessor
            // 
            this.dgProfessor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgProfessor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfessor.Location = new System.Drawing.Point(163, 205);
            this.dgProfessor.Name = "dgProfessor";
            this.dgProfessor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProfessor.Size = new System.Drawing.Size(728, 278);
            this.dgProfessor.TabIndex = 9;
            this.dgProfessor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProfessor_CellContentClick);
            this.dgProfessor.Click += new System.EventHandler(this.dgAlunos_Click);
            this.dgProfessor.DoubleClick += new System.EventHandler(this.dgProfessor_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 26);
            this.label8.TabIndex = 134;
            this.label8.Text = "Sessão: CD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aquamarine;
            this.label7.Location = new System.Drawing.Point(69, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 23);
            this.label7.TabIndex = 135;
            this.label7.Text = "Formulário: Professor";
            // 
            // DCProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Chamadaa.Properties.Resources.Fundo_controles;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbModalidade);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtNomeProf);
            this.Controls.Add(this.dgProfessor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DCProfessor";
            this.Text = "DCProfessor";
            this.Load += new System.EventHandler(this.DCProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbModalidade;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomeProf;
        public System.Windows.Forms.DataGridView dgProfessor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}