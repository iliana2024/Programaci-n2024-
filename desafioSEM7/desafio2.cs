using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafiosSEM7
{
    public interface INotificable
    {
        void Notificar(string mensaje);
    }

    public class NotificacionEmail : INotificable
    {
        private string direccionCorreo;

        public NotificacionEmail(string direccionCorreo)
        {
            this.direccionCorreo = direccionCorreo;
        }

        public void Notificar(string mensaje)
        {
            Console.WriteLine($"Enviando email a {direccionCorreo}: {mensaje}");
            // Aquí iría el código para enviar el email
        }
    }

    public class NotificacionWhatsap : INotificable
    {
        private string numeroTelefono;

        public NotificacionWhatsap(string numeroTelefono)
        {
            this.numeroTelefono = numeroTelefono;
        }

        public void Notificar(string mensaje)
        {
            Console.WriteLine($"Enviando mensaje de Whatsapp al número {numeroTelefono}: {mensaje}");
            // Aquí iría el código para enviar el mensaje de Whatsapp
        }
    }

    public class NotificacionSMS : INotificable
    {
        private string numeroTelefono;

        public NotificacionSMS(string numeroTelefono)
        {
            this.numeroTelefono = numeroTelefono;
        }

        public void Notificar(string mensaje)
        {
            Console.WriteLine($"Enviando SMS al número {numeroTelefono}: {mensaje}");
            // Aquí iría el código para enviar el SMS
        }
    }

    class desafiosSEM7
    {
        static void Main(string[] args)
        {
            NotificacionEmail emailNotificacion = new NotificacionEmail("ejemplo@gmail.com");
            NotificacionWhatsap whatsapNotificacion = new NotificacionWhatsap("+123456789");
            NotificacionSMS smsNotificacion = new NotificacionSMS("+987654321");

            emailNotificacion.Notificar("Este es un mensaje de prueba por email.");
            whatsapNotificacion.Notificar("Este es un mensaje de prueba por Whatsapp.");
            smsNotificacion.Notificar("Este es un mensaje de prueba por SMS.");
        }
    }
}
