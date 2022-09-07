using WebApp.Models.Requests.CardRequest;
using WebApp.Models.Responses.CardResponse;

namespace WebApp.Services
{
    public interface ICardService
    {
        Task<CardListResponse> GetAllCard();

        Task<CardByIdResponse> GetCardById(GetCardByIdRequest request);

        Task CreateCard(CreateCardRequest request);

        Task UpdateCard(UpdateCardRequest request);

        Task DeleteCard(DeleteCardRequest request);
    }
}
