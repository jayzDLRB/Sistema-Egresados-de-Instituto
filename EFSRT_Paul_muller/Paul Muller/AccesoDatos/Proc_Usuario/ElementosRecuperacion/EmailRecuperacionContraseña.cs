using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Proc_Usuario.ElementosRecuperacion
{
    public class EmailRecuperacionContraseña
    {
        Entidades.Usuarios.ElementosRecuperacionContraseña obj = new Entidades.Usuarios.ElementosRecuperacionContraseña();
        protected void iniciarSmptClient() 
        {         
            obj.smtClient =new SmtpClient();
            obj.smtClient.Credentials = new NetworkCredential(obj.senderMail, obj.rcpcontrasena);
            obj.smtClient.Host= obj.host;
            obj.smtClient.Port = obj.port;
            obj.smtClient.EnableSsl = obj.ssl;
        }

        public void sendMail(string subject, string body, List<string> recipientMail) 
        {
            var mailMessage = new MailMessage();
            try {

                mailMessage.From = new MailAddress(obj.senderMail);

                foreach (string mail in recipientMail) 
                {
                    mailMessage.To.Add(mail);
                }

                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority =MailPriority.Normal;
                obj.smtClient.Send(mailMessage);
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Error al enviar el correo:{ex.Message}");
            }finally 
            {
                mailMessage.Dispose();
                obj.smtClient.Dispose();
            }
        }
    }
}
