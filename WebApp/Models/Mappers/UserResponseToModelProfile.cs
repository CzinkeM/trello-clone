using AutoMapper;
using WebApp.Models.Responses.UserResponse;

namespace WebApp.Models.Mappers
{
    public class UserResponseToModelProfile : Profile
    {
        public UserResponseToModelProfile()
        {
            CreateMap<UserResponse, User>();
            CreateMap<UserListResponse, UserList>();
        }
    }
}