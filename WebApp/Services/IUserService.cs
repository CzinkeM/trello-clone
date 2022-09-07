using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Requests.UserRequest;
using WebApp.Models.Responses.UserResponse;

namespace WebApp.Services
{
    public interface IUserService
    {
        public string Token { get; set; }
        Task<SignInResponse> SignIn(SignInRequest request);

        Task SignUp(SignUpRequest request);

        Task<string> ListAllUsers();

    }
}
