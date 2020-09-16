using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Financiero.Modelo
{
    public class EmailSender : IEmailSender
    {
        private SmtpClient _smtpClient { get; set; }
        private string _emailFrom { get; set; }


        public EmailSender(EmailSenderOptions options)
        {
            _smtpClient = new SmtpClient()
            {
                Host = options.Host,
                Port = options.Port,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(options.Email, options.Password),
                EnableSsl = options.EnableSsl
                
            };
            _emailFrom = options.Email;
        }

        public Task SendEmailAsync(string emailFrom, string message)
        {
            var correo = new MailMessage(from: _emailFrom, to: emailFrom, subject: emailFrom, body: message);
            correo.IsBodyHtml = false;
            return _smtpClient.SendMailAsync(correo);
        }
    }
}
