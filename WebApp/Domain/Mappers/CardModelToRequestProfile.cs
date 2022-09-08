using AutoMapper;
using WebApp.Models.Requests.CardRequest;

namespace WebApp.Models.Mappers
{
    public class CardModelToRequestProfile : Profile
    {
        public CardModelToRequestProfile()
        {
            CreateMap<SimpleCard, CreateCardRequest>();
            CreateMap<SimpleCard, DeleteCardRequest>();
            CreateMap<SimpleCard, GetCardByIdRequest>();
            CreateMap<SimpleCard, UpdateCardRequest>();
        }
    }
}