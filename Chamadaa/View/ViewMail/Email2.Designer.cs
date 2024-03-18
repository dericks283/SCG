namespace Chamadaa.View.ViewMail
{
    partial class Email2
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
            this.rtxtEmailrecebi = new System.Windows.Forms.RichTextBox();
            this.rtxtCorpo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailEmi = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtEmailDest = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtEmailrecebi
            // 
            this.rtxtEmailrecebi.Location = new System.Drawing.Point(460, 50);
            this.rtxtEmailrecebi.Name = "rtxtEmailrecebi";
            this.rtxtEmailrecebi.Size = new System.Drawing.Size(301, 479);
            this.rtxtEmailrecebi.TabIndex = 0;
            this.rtxtEmailrecebi.Text = "";
            // 
            // rtxtCorpo
            // 
            this.rtxtCorpo.Location = new System.Drawing.Point(17, 283);
            this.rtxtCorpo.Name = "rtxtCorpo";
            this.rtxtCorpo.Size = new System.Drawing.Size(358, 217);
            this.rtxtCorpo.TabIndex = 1;
            this.rtxtCorpo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Corpo da Mensagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email emissor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email Destinatário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Assunto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mensagens recebidas";
            // 
            // txtEmailEmi
            // 
            this.txtEmailEmi.Location = new System.Drawing.Point(117, 52);
            this.txtEmailEmi.Name = "txtEmailEmi";
            this.txtEmailEmi.Size = new System.Drawing.Size(258, 20);
            this.txtEmailEmi.TabIndex = 8;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(117, 196);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(186, 20);
            this.txtAssunto.TabIndex = 9;
            // 
            // txtEmailDest
            // 
            this.txtEmailDest.Location = new System.Drawing.Point(117, 145);
            this.txtEmailDest.Name = "txtEmailDest";
            this.txtEmailDest.Size = new System.Drawing.Size(237, 20);
            this.txtEmailDest.TabIndex = 10;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(117, 93);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(155, 20);
            this.txtSenha.TabIndex = 11;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(300, 506);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // Email2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 584);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmailDest);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtEmailEmi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtCorpo);
            this.Controls.Add(this.rtxtEmailrecebi);
            this.Name = "Email2";
            this.Text = "Email2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtEmailrecebi;
        private System.Windows.Forms.RichTextBox rtxtCorpo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailEmi;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtEmailDest;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEnviar;
    }
}