using System.Net;
using System.Net.Mail;

namespace Enviar_emails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.office365.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("kamykaze_shogun@hotmail.com", "@Marcel89");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("kamykaze_shogun@hotmail.com");
                mailMessage.To.Add(new MailAddress("kamykaze_shogun@hotmail.com"));
                mailMessage.Subject = "Meu primeiro email";
                mailMessage.Body = "Olá. Este é o meu primeiro email enviado pelo C#!";
                mailMessage.IsBodyHtml = false;

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.office365.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("kamykaze_shogun@hotmail.com", "@Marcel89");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("kamykaze_shogun@hotmail.com");
                mailMessage.To.Add(new MailAddress("kamykaze_shogun@hotmail.com"));
                mailMessage.Subject = "Meu primeiro email";
                mailMessage.Body = "Olá. Este é o meu primeiro email enviado pelo C#!";
                mailMessage.IsBodyHtml = false;

                Attachment arquivoAnexo = new Attachment(@"C:\Users\marce\Desktop\anotações healthTech.docx");
                mailMessage.Attachments.Add(arquivoAnexo);

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.office365.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("kamykaze_shogun@hotmail.com", "@Marcel89");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("kamykaze_shogun@hotmail.com");
                mailMessage.To.Add(new MailAddress("kamykaze_shogun@hotmail.com"));
                mailMessage.Subject = "Meu primeiro email";
                string body = "Olá. Este é o meu primeiro email enviado pelo C#!";
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = false;

                string caminhoImagem = @"C:\Users\marce\Desktop\tatuagens\Imagem do WhatsApp de 2025-01-17 à(s) 17.24.54_dc6877fc.jpg";

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
