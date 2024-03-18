namespace Chamadaa.View.ViewCadastros
{
    partial class CadProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadProfessor));
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.txtEmailProf = new System.Windows.Forms.TextBox();
            this.txtTelProf = new System.Windows.Forms.TextBox();
            this.dgProfessores = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfessores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeProf.BackColor = System.Drawing.Color.Black;
            this.txtNomeProf.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtNomeProf.ForeColor = System.Drawing.Color.Silver;
            this.txtNomeProf.Location = new System.Drawing.Point(348, 231);
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.Size = new System.Drawing.Size(302, 23);
            this.txtNomeProf.TabIndex = 3;
            this.txtNomeProf.Text = "Nome*";
            this.txtNomeProf.Enter += new System.EventHandler(this.txtNomeProf_Enter);
            this.txtNomeProf.Leave += new System.EventHandler(this.txtNomeProf_Leave);
            // 
            // txtEmailProf
            // 
            this.txtEmailProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailProf.BackColor = System.Drawing.Color.Black;
            this.txtEmailProf.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtEmailProf.ForeColor = System.Drawing.Color.Silver;
            this.txtEmailProf.Location = new System.Drawing.Point(348, 272);
            this.txtEmailProf.Name = "txtEmailProf";
            this.txtEmailProf.Size = new System.Drawing.Size(302, 23);
            this.txtEmailProf.TabIndex = 4;
            this.txtEmailProf.Text = "Email*";
            this.txtEmailProf.Enter += new System.EventHandler(this.txtEmailProf_Enter);
            this.txtEmailProf.Leave += new System.EventHandler(this.txtEmailProf_Leave);
            // 
            // txtTelProf
            // 
            this.txtTelProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelProf.BackColor = System.Drawing.Color.Black;
            this.txtTelProf.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.txtTelProf.ForeColor = System.Drawing.Color.Silver;
            this.txtTelProf.Location = new System.Drawing.Point(348, 316);
            this.txtTelProf.MaxLength = 13;
            this.txtTelProf.Name = "txtTelProf";
            this.txtTelProf.Size = new System.Drawing.Size(182, 23);
            this.txtTelProf.TabIndex = 5;
            this.txtTelProf.Text = "Telefone*";
            this.txtTelProf.Enter += new System.EventHandler(this.txtTelProf_Enter);
            this.txtTelProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelProf_KeyPress);
            this.txtTelProf.Leave += new System.EventHandler(this.txtTelProf_Leave);
            // 
            // dgProfessores
            // 
            this.dgProfessores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfessores.Location = new System.Drawing.Point(317, 357);
            this.dgProfessores.Name = "dgProfessores";
            this.dgProfessores.Size = new System.Drawing.Size(371, 150);
            this.dgProfessores.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Silver;
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnReset.Location = new System.Drawing.Point(694, 357);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 97;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 118;
            this.label3.Text = "Professores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 117;
            this.label2.Text = "Sessão: Cadastros";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox2.Location = new System.Drawing.Point(98, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 48);
            this.pictureBox2.TabIndex = 120;
            this.pictureBox2.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackgroundImage = global::Chamadaa.Properties.Resources.btn_cadastrar;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCadastrar.Location = new System.Drawing.Point(536, 300);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(114, 51);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.Location = new System.Drawing.Point(98, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(211, 67);
            this.pictureBox3.TabIndex = 121;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Chamadaa.Properties.Resources.fundo_cad;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(98, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(772, 484);
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // CadProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgProfessores);
            this.Controls.Add(this.txtTelProf);
            this.Controls.Add(this.txtEmailProf);
            this.Controls.Add(this.txtNomeProf);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadProfessor";
            this.Text = "CadProfessor";
            this.Load += new System.EventHandler(this.CadProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProfessores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeProf;
        private System.Windows.Forms.TextBox txtEmailProf;
        private System.Windows.Forms.TextBox txtTelProf;
        private System.Windows.Forms.DataGridView dgProfessores;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}