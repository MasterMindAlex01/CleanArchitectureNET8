using Application.Interfaces.Common;
using Application.Requests.Identity;
using Application.Responses.Identity;
using Shared.Wrapper;
using System.Threading.Tasks;

namespace Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}