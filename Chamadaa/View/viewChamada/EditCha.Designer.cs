namespace Chamadaa.View.viewChamada
{
    partial class EditCha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCha));
            this.btnAllAu = new System.Windows.Forms.Button();
            this.btnAllPre = new System.Windows.Forms.Button();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.txtNovCha = new System.Windows.Forms.TextBox();
            this.dgAlunos = new System.Windows.Forms.DataGridView();
            this.btnFalta = new System.Windows.Forms.Button();
            this.btnPresente = new System.Windows.Forms.Button();
            this.lblModalidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllAu
            // 
            this.btnAllAu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllAu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllAu.Location = new System.Drawing.Point(175, 375);
            this.btnAllAu.Name = "btnAllAu";
            this.btnAllAu.Size = new System.Drawing.Size(127, 25);
            this.btnAllAu.TabIndex = 70;
            this.btnAllAu.Text = "MT Ausente";
            this.btnAllAu.UseVisualStyleBackColor = true;
            this.btnAllAu.Click += new System.EventHandler(this.btnAllAu_Click);
            // 
            // btnAllPre
            // 
            this.btnAllPre.BackColor = System.Drawing.Color.White;
            this.btnAllPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllPre.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPre.Location = new System.Drawing.Point(15, 375);
            this.btnAllPre.Name = "btnAllPre";
            this.btnAllPre.Size = new System.Drawing.Size(124, 25);
            this.btnAllPre.TabIndex = 69;
            this.btnAllPre.Text = "MT Presente";
            this.btnAllPre.UseVisualStyleBackColor = false;
            this.btnAllPre.Click += new System.EventHandler(this.btnAllPre_Click);
            // 
            // txtTurma
            // 
            this.txtTurma.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurma.Location = new System.Drawing.Point(76, 257);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.ReadOnly = true;
            this.txtTurma.Size = new System.Drawing.Size(100, 23);
            this.txtTurma.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "Turma:";
            // 
            // txtHorario
            // 
            this.txtHorario.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorario.Location = new System.Drawing.Point(185, 257);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(100, 23);
            this.txtHorario.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 64;
            this.label1.Text = "Horario da Aula:";
            // 
            // txtProfessor
            // 
            this.txtProfessor.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessor.Location = new System.Drawing.Point(85, 192);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.Size = new System.Drawing.Size(139, 23);
            this.txtProfessor.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Professor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 61;
            this.label3.Text = "Dia de Hoje:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(86, 148);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(139, 23);
            this.txtNome.TabIndex = 58;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(134, 94);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(35, 23);
            this.txtId.TabIndex = 57;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(104, 97);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(24, 15);
            this.id.TabIndex = 56;
            this.id.Text = "ID:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(83, 130);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(39, 15);
            this.nome.TabIndex = 55;
            this.nome.Text = "Nome:";
            // 
            // txtNovCha
            // 
            this.txtNovCha.Enabled = false;
            this.txtNovCha.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovCha.Location = new System.Drawing.Point(563, 66);
            this.txtNovCha.Name = "txtNovCha";
            this.txtNovCha.ReadOnly = true;
            this.txtNovCha.Size = new System.Drawing.Size(101, 23);
            this.txtNovCha.TabIndex = 54;
            // 
            // dgAlunos
            // 
            this.dgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlunos.Location = new System.Drawing.Point(321, 111);
            this.dgAlunos.Name = "dgAlunos";
            this.dgAlunos.Size = new System.Drawing.Size(530, 274);
            this.dgAlunos.TabIndex = 51;
            this.dgAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlunos_CellClick);
            // 
            // btnFalta
            // 
            this.btnFalta.BackgroundImage = global::Chamadaa.Properties.Resources.btnAusente;
            this.btnFalta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFalta.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFalta.Location = new System.Drawing.Point(175, 313);
            this.btnFalta.Name = "btnFalta";
            this.btnFalta.Size = new System.Drawing.Size(127, 56);
            this.btnFalta.TabIndex = 60;
            this.btnFalta.Text = "Ausente";
            this.btnFalta.UseVisualStyleBackColor = true;
            this.btnFalta.Click += new System.EventHandler(this.btnFalta_Click);
            // 
            // btnPresente
            // 
            this.btnPresente.BackgroundImage = global::Chamadaa.Properties.Resources.btnPresente;
            this.btnPresente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPresente.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresente.Location = new System.Drawing.Point(12, 313);
            this.btnPresente.Name = "btnPresente";
            this.btnPresente.Size = new System.Drawing.Size(127, 56);
            this.btnPresente.TabIndex = 59;
            this.btnPresente.Text = "Presente";
            this.btnPresente.UseVisualStyleBackColor = true;
            this.btnPresente.Click += new System.EventHandler(this.btnPresente_Click);
            // 
            // lblModalidade
            // 
            this.lblModalidade.AutoSize = true;
            this.lblModalidade.BackColor = System.Drawing.Color.Transparent;
            this.lblModalidade.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidade.ForeColor = System.Drawing.Color.White;
            this.lblModalidade.Location = new System.Drawing.Point(103, 34);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(94, 23);
            this.lblModalidade.TabIndex = 71;
            this.lblModalidade.Text = "Modalidade";
            // 
            // EditCha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Chamadaa.Properties.Resources.fundo_edit_chamada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 413);
            this.Controls.Add(this.lblModalidade);
            this.Controls.Add(this.btnAllAu);
            this.Controls.Add(this.btnAllPre);
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
            this.Controls.Add(this.dgAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCha";
            this.Load += new System.EventHandler(this.EditCha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllAu;
        private System.Windows.Forms.Button btnAllPre;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFalta;
        private System.Windows.Forms.Button btnPresente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox txtNovCha;
        private System.Windows.Forms.DataGridView dgAlunos;
        private System.Windows.Forms.Label lblModalidade;
    }
}