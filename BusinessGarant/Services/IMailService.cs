using BusinessGarant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessGarant.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(string fileName, string subject, byte[] atachment, string message);
        Task SendEmailAsync(string fileName, string message);
    }
}
