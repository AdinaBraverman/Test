using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace Utils
{
    public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public MailRequest(string toEmail,string subject,string body)
        {
            Body = body; 
            ToEmail = toEmail; 
            Subject = subject;
        }
    }
}
