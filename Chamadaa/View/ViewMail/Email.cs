using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Linq.Expressions;

namespace Chamadaa.View.ViewMail
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SmtpClient cliente = new SmtpClient();
            NetworkCredential credenciais = new NetworkCredential();

            //porta e servidor da conta de email que vai enviar o conteúdo
            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;

            // definir que o vliente possui o sistema de encriptação Security Sockets Layer(SSL)
            cliente.EnableSsl = true;

            //especificando o metodo de envio da mensagem (sistema SMTP for the Network)
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;

            //credenciais de acesso a conta de email
            credenciais.UserName = "test357489126tcc";
            credenciais.Password = "Emailteste01";

            //atribuindo credenciais do cliente
            cliente.Credentials = credenciais;



            //informações relacionadas ao corpo da mensagem
            MailMessage mensagem = new MailMessage();

            //informações da fonte da mensagem 
            //Emissor
            mensagem.From = new MailAddress("test357489126tcc@gmail.com");
            //assunto
            mensagem.Subject = "Teste";
            //corpo 
            mensagem.Body = "======Corpo da Mensagem======";

            //Informações de destinatário
            mensagem.To.Add("test357489126tcc@gmail.com");

            //envio da mensagem
            cliente.Send(mensagem);

            MessageBox.Show("ok");


       }
    }
}
