using System;
using System.Threading.Tasks;

namespace Financiero.Modelo
{
    interface IEmailSender
    {
        Task SendEmailAsync(string emailFrom, string message);       
    }
}
