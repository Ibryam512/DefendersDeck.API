using DefendersDeck.Business.Responses;

namespace DefendersDeck.Business.Contracts
{
    public interface IAuthService
    {
        Task<BaseResponse<string>> Register(Requests.RegisterRequest request);
        Task<BaseResponse<string>> Login(Requests.LoginRequest request);
    }
}
