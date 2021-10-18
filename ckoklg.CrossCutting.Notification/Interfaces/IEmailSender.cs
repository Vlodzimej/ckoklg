using System.Collections.Generic;
using System.Threading.Tasks;
using ckoklg.CrossCutting.Notification.ViewModels;

namespace ckoklg.CrossCutting.Notification.Interfaces
{
    public interface IEmailSender
    {
        void SendEmail(EmailViewModel message, IEnumerable<string> parameters);
        Task SendEmailAsync(EmailViewModel message, IEnumerable<string> parameters);
    }
}
