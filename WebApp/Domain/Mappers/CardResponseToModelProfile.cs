using AutoMapper;
using WebApp.Models.Responses.CardResponse;

namespace WebApp.Models.Mappers
{
    public class CardResponseToModelProfile : Profile
    {
        public CardResponseToModelProfile()
        {
            CreateMap<CardByIdResponse, DetailedCard>();
            CreateMap<List<SimpleCardResponse>, List<SimpleCard>>();
            CreateMap<List<SimpleCardResponse>, List<SimpleCard>>();
        }
    }
}