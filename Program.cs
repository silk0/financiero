using Financiero.Modelo;
using System;
using System.Net.Configuration;
using System.Net.Mail;
using System.Windows.Forms;

namespace Financiero
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.Read();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InicioSesion());


            /*EmailSenderOptions option = new EmailSenderOptions();
            EmailSender emailSender = new EmailSender(option);
            emailSender.SendEmailAsync("silkfirmyn@gmail.com","Envio de token");
            MessageBox.Show("Correo Enviado correctamente");*/
                   
        }
    }
}
