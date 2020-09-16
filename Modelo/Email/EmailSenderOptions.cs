using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiero.Modelo

{
    public class EmailSenderOptions
    {
        public int Port { get; }
        public string Email { get; }
        public string Password { get; }
        public bool EnableSsl { get;  }
        public string Host { get;  }

        public EmailSenderOptions() {
            Host = "smtp.gmail.com";
            Email = "programafinancierotoken@gmail.com";
            Password = "programafinanci3ro2";
            Port = 587;
            EnableSsl = true;
        }

        
    }
}
