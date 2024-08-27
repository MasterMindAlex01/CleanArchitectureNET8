using Application.Requests.Mail;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}