using Microsoft.Extensions.Options;
using SendingMailsWithSMTP.Models;

namespace SendingMailsWithSMTP.Services
{
    public class MailingService : IMailingService
    {
        private MailSettings _mailSettings;

        public MailingService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public Task SendEmailAsync(string mailTo, string subject, string body, IList<IFormFile> attachments = null)
        {
            throw new NotImplementedException();
        }
    }
}
