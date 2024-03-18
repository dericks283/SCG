namespace Chamadaa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFalta = new System.Windows.Forms.Button();
            this.btnPresente = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.txtNovCha = new System.Windows.Forms.TextBox();
            this.btnNovCha = new System.Windows.Forms.Button();
            this.dgAlunos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModalidade = new System.Windows.Forms.Label();
            this.btnAllPre = new System.Windows.Forms.Button();
            this.btnAllAu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFalta
            // 
            this.btnFalta.BackgroundImage = global::Chamadaa.Properties.Resources.btnAusente;
            this.btnFalta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFalta.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFalta.Location = new System.Drawing.Point(164, 326);
            this.btnFalta.Name = "btnFalta";
            this.btnFalta.Size = new System.Drawing.Size(129, 56);
            this.btnFalta.TabIndex = 39;
            this.btnFalta.Text = "Ausente";
            this.btnFalta.UseVisualStyleBackColor = true;
            this.btnFalta.Click += new System.EventHandler(this.btnFalta_Click);
            // 
            // btnPresente
            // 
            this.btnPresente.BackgroundImage = global::Chamadaa.Properties.Resources.btnPresente;
            this.btnPresente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPresente.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresente.Location = new System.Drawing.Point(35, 326);
            this.btnPresente.Name = "btnPresente";
            this.btnPresente.Size = new System.Drawing.Size(123, 56);
            this.btnPresente.TabIndex = 38;
            this.btnPresente.Text = "Presente";
            this.btnPresente.UseVisualStyleBackColor = true;
            this.btnPresente.Click += new System.EventHandler(this.btnPresente_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(106, 168);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(132, 23);
            this.txtNome.TabIndex = 30;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(106, 133);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(35, 23);
            this.txtId.TabIndex = 29;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(65, 136);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(24, 15);
            this.id.TabIndex = 28;
            this.id.Text = "ID:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.BackColor = System.Drawing.Color.Transparent;
            this.nome.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(49, 171);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(39, 15);
            this.nome.TabIndex = 24;
            this.nome.Text = "Nome:";
            // 
            // txtNovCha
            // 
            this.txtNovCha.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovCha.Location = new System.Drawing.Point(388, 118);
            this.txtNovCha.Name = "txtNovCha";
            this.txtNovCha.Size = new System.Drawing.Size(101, 23);
            this.txtNovCha.TabIndex = 23;
            // 
            // btnNovCha
            // 
            this.btnNovCha.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovCha.Location = new System.Drawing.Point(553, 114);
            this.btnNovCha.Name = "btnNovCha";
            this.btnNovCha.Size = new System.Drawing.Size(139, 28);
            this.btnNovCha.TabIndex = 22;
            this.btnNovCha.Text = "Adicionar nova chamada";
            this.btnNovCha.UseVisualStyleBackColor = true;
            this.btnNovCha.Click += new System.EventHandler(this.btnNovCha_Click);
            // 
            // dgAlunos
            // 
            this.dgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlunos.Location = new System.Drawing.Point(271, 168);
            this.dgAlunos.Name = "dgAlunos";
            this.dgAlunos.Size = new System.Drawing.Size(561, 150);
            this.dgAlunos.TabIndex = 20;
            this.dgAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlunos_CellClick);
            this.dgAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlunos_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Dia de Hoje:";
            // 
            // txtProfessor
            // 
            this.txtProfessor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessor.Location = new System.Drawing.Point(106, 230);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.Size = new System.Drawing.Size(132, 23);
            this.txtProfessor.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Professor:";
            // 
            // txtTurma
            // 
            this.txtTurma.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurma.Location = new System.Drawing.Point(106, 258);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.ReadOnly = true;
            this.txtTurma.Size = new System.Drawing.Size(100, 23);
            this.txtTurma.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Turma:";
            // 
            // txtHorario
            // 
            this.txtHorario.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorario.Location = new System.Drawing.Point(106, 284);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(100, 23);
            this.txtHorario.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Horario da Aula:";
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.BackColor = System.Drawing.Color.Transparent;
            this.lblModalidade.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidade.ForeColor = System.Drawing.Color.White;
            this.lblModalidade.Location = new System.Drawing.Point(102, 40);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(94, 23);
            this.lblModalidade.TabIndex = 48;
            this.lblModalidade.Text = "Modalidade";
            // 
            // btnAllPre
            // 
            this.btnAllPre.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPre.Location = new System.Drawing.Point(35, 388);
            this.btnAllPre.Name = "btnAllPre";
            this.btnAllPre.Size = new System.Drawing.Size(123, 25);
            this.btnAllPre.TabIndex = 49;
            this.btnAllPre.Text = "MT como Presentes";
            this.btnAllPre.UseVisualStyleBackColor = true;
            this.btnAllPre.Click += new System.EventHandler(this.btnAllPre_Click);
            // 
            // btnAllAu
            // 
            this.btnAllAu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllAu.Location = new System.Drawing.Point(164, 388);
            this.btnAllAu.Name = "btnAllAu";
            this.btnAllAu.Size = new System.Drawing.Size(129, 25);
            this.btnAllAu.TabIndex = 50;
            this.btnAllAu.Text = "MT como Ausentes";
            this.btnAllAu.UseVisualStyleBackColor = true;
            this.btnAllAu.Click += new System.EventHandler(this.btnAllAu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chamadaa.Properties.Resources.fundo_edit_chamada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.btnAllAu);
            this.Controls.Add(this.btnAllPre);
            this.Controls.Add(this.lblModalidade);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFalta);
            this.Controls.Add(this.btnPresente);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.id);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.txtNovCha);
            this.Controls.Add(this.btnNovCha);
            this.Controls.Add(this.dgAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFalta;
        private System.Windows.Forms.Button btnPresente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox txtNovCha;
        private System.Windows.Forms.Button btnNovCha;
        private System.Windows.Forms.DataGridView dgAlunos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModalidade;
        private System.Windows.Forms.Button btnAllPre;
        private System.Windows.Forms.Button btnAllAu;
        private System.Windows.Forms.TextBox txtId;
    }
}

