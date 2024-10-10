using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Proc_Usuario.ElementosRecuperacion
{
    class SystemSupportMail : EmailRecuperacionContraseña
    {
        public SystemSupportMail() 
        {
            Entidades.Usuarios.ElementosRecuperacionContraseña obj = new Entidades.Usuarios.ElementosRecuperacionContraseña();
            obj.senderMail = "systemssptteam@gmail.com";
            obj.rcpcontrasena = "vkfm bryb aolw ybqd";
            obj.host= "smtp.gmail.com";
            obj.port = 587;
            obj.ssl = true;
            iniciarSmptClient();
        }
    }
}
