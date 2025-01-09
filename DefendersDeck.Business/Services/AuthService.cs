using DefendersDeck.Business.Contracts;
using DefendersDeck.Business.Responses;
using DefendersDeck.DataAccess.Contracts;
using DefendersDeck.Domain.Entities;

namespace DefendersDeck.Business.Services
{
    public class AuthService(IRepository<User> userRepository, ICardService cardService, IPasswordHasher passwordHasher, ITokenProvider tokenProvider) : IAuthService
    {
        public async Task<BaseResponse<string>> Login(Requests.LoginRequest request)
        {
            var user = await userRepository.FindSingleAsync(x => x.Username == request.Username);

            if (user is null)
            {
                return BaseResponse<string>.Unauthorized();
            }

            bool passwordsAreEqual = passwordHasher.Verify(request.Password, user.PasswordHash);

            if (!passwordsAreEqual)
            {
                return BaseResponse<string>.Unauthorized();
            }

            var token = tokenProvider.CreateToken(user);

            return BaseResponse<string>.Successful(token);
        }

        public async Task<BaseResponse<string>> Register(Requests.RegisterRequest request)
        {
            var user = await userRepository.FindSingleAsync(x => x.Username == request.Username);

            if (user is not null)
            {
               return new BaseResponse<string> 
               {
                   Success = false,
                   StatusCode = System.Net.HttpStatusCode.Conflict,
                   Message = "User with this username already exists"
               };
            }

            string passwordHash = passwordHasher.Hash(request.Password);
            var deck = await cardService.GenerateDeck();

            var newUser = new User
            {
                Username = request.Username,
                PasswordHash = passwordHash,
                ProfileImageUrl = "",
                Cards = deck.ToList()
            };

            await userRepository.AddAsync(newUser);
            var token = tokenProvider.CreateToken(newUser);

            return BaseResponse<string>.Successful(token);
        }
    }
}
