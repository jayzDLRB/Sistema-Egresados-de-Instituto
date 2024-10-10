using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Usuarios
{
    public class ElementosRecuperacionContraseña
    {
        public SmtpClient smtClient;
        public string senderMail { get; set; }
        public string rcpcontrasena { get;set; }
        public string  host { get; set; }
        public int port { get; set;}
        public bool ssl { get; set; }
    }
}
