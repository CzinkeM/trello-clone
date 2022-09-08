using AutoMapper;
using WebApp.Models.Requests.UserRequest;

namespace WebApp.Models.Mappers
{
    public class UserModelToRequestProfile : Profile
    {
        public UserModelToRequestProfile()
        {
            CreateMap<UserCredentials, SignInRequest>();
            CreateMap<UserCredentials, SignUpRequest>();
        }
    }
}