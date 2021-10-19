using System.Collections.Generic;
using System.Threading.Tasks;
using Ckoklg.CrossCutting.Notification.ViewModels;

namespace Ckoklg.CrossCutting.Notification.Interfaces
{
    public interface IEmailSender
    {
        void SendEmail(EmailViewModel message, IEnumerable<string> parameters);
        Task SendEmailAsync(EmailViewModel message, IEnumerable<string> parameters);
    }
}
