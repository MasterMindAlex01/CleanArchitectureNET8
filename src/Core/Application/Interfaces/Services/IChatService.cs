using Application.Responses.Identity;
using Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Interfaces.Chat;
using Application.Models.Chat;

namespace Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}