using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace C.PL.FUNC
{
    public class MailSupport
    {
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public MailSupport(string mail, string _pass)
        {
            EMAIL = mail;
            PASSWORD = _pass;
        }

        public void send(string mailto, string _subject, string content)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");// 

            mail.From = new MailAddress(EMAIL);
            mail.To.Add(mailto);
            mail.Subject = _subject;
            mail.IsBodyHtml = true;
            mail.Body = content;

            SmtpServer.Port = 465;
            SmtpServer.Credentials = new System.Net.NetworkCredential(EMAIL, PASSWORD);
            SmtpServer.EnableSsl = true;
            
            SmtpServer.Send(mail);

        }
    }
}
