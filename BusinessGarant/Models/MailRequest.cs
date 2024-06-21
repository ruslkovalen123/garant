using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessGarant.Models
{
    public class MailRequest : IMailRequest
    {
        public string ToEmail { get; set; } = "gp.garant.su@ukr.net";
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<IFormFile> Attachments { get; set; }
    }
}
