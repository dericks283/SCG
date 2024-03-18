namespace Chamadaa.View.viewChamada
{
    partial class ChamadaAnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChamadaAnt));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbModa = new System.Windows.Forms.ComboBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.dgvCham = new System.Windows.Forms.DataGridView();
            this.btnExclu = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPesqui = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCham)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Turma:";
            // 
            // cbModa
            // 
            this.cbModa.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModa.FormattingEnabled = true;
            this.cbModa.Items.AddRange(new object[] {
            "Basquete",
            "Futsal",
            "Volei",
            "Handebol"});
            this.cbModa.Location = new System.Drawing.Point(19, 52);
            this.cbModa.Name = "cbModa";
            this.cbModa.Size = new System.Drawing.Size(140, 23);
            this.cbModa.TabIndex = 3;
            this.cbModa.Text = "Modalidade";
            // 
            // txtTurma
            // 
            this.txtTurma.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurma.Location = new System.Drawing.Point(243, 82);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(137, 23);
            this.txtTurma.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(442, 85);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(139, 23);
            this.txtData.TabIndex = 6;
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtData_KeyPress);
            // 
            // dgvCham
            // 
            this.dgvCham.AllowUserToDeleteRows = false;
            this.dgvCham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCham.Location = new System.Drawing.Point(19, 118);
            this.dgvCham.Name = "dgvCham";
            this.dgvCham.ReadOnly = true;
            this.dgvCham.Size = new System.Drawing.Size(757, 244);
            this.dgvCham.TabIndex = 8;
            // 
            // btnExclu
            // 
            this.btnExclu.BackgroundImage = global::Chamadaa.Properties.Resources.btn_excluir;
            this.btnExclu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExclu.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExclu.Location = new System.Drawing.Point(423, 368);
            this.btnExclu.Name = "btnExclu";
            this.btnExclu.Size = new System.Drawing.Size(187, 50);
            this.btnExclu.TabIndex = 10;
            this.btnExclu.Text = "Excluir Chamada";
            this.btnExclu.UseVisualStyleBackColor = true;
            this.btnExclu.Click += new System.EventHandler(this.btnExclu_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::Chamadaa.Properties.Resources.btn_edit_Chamada;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(193, 368);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(187, 50);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Editar Chamada";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPesqui
            // 
            this.btnPesqui.BackgroundImage = global::Chamadaa.Properties.Resources.btn_Pesquisar;
            this.btnPesqui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesqui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesqui.Location = new System.Drawing.Point(621, 80);
            this.btnPesqui.Name = "btnPesqui";
            this.btnPesqui.Size = new System.Drawing.Size(117, 31);
            this.btnPesqui.TabIndex = 7;
            this.btnPesqui.Text = "Pesquisar";
            this.btnPesqui.UseVisualStyleBackColor = true;
            this.btnPesqui.Click += new System.EventHandler(this.btnPesqui_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackgroundImage = global::Chamadaa.Properties.Resources.btn_carregar;
            this.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsulta.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(50, 83);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(109, 29);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // ChamadaAnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Chamadaa.Properties.Resources.fundo_Chamada_ant;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 473);
            this.Controls.Add(this.btnExclu);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvCham);
            this.Controls.Add(this.btnPesqui);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.cbModa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChamadaAnt";
            this.Text = "ChamadaAnt";
            this.Load += new System.EventHandler(this.ChamadaAnt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbModa;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnPesqui;
        private System.Windows.Forms.DataGridView dgvCham;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExclu;
    }
}