using Microsoft.Extensions.Options;
using WebApp.Models.Requests.CardRequest;
using WebApp.Models.Responses.CardResponse;
using WebApp.Settings;

namespace WebApp.Services
{
    public class CardService : ICardService
    {
        private readonly ApiOptions _apiOptions;
        private readonly HttpClient _httpClient;
        private readonly AuthenticationService _authenticationService;
        private readonly Uri _baseUri;

        public CardService(IOptions<ApiOptions> apiOptions, HttpClient httpClient, AuthenticationService authenticationService)
        {
            _apiOptions = apiOptions.Value;
            _httpClient = httpClient;
            _authenticationService = authenticationService;
            _baseUri = new Uri(_apiOptions.BaseUri);
            _httpClient.BaseAddress = _baseUri;
        }

        public async Task CreateCard(CreateCardRequest request)
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authenticationService.Token}");
            var response = await _httpClient.PostAsJsonAsync(new Uri(_baseUri, _apiOptions.Card.CreateCardPath), request);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteCard(DeleteCardRequest request)
        {
            HttpRequestMessage requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                Content = JsonContent.Create(request),
                RequestUri = new Uri(_baseUri, _apiOptions.Card.DeleteCardPath),
            };
            var response = await _httpClient.SendAsync(requestMessage);
            response.EnsureSuccessStatusCode();
        }

        public async Task<CardListResponse> GetAllCard()
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authenticationService.Token}");
            var response = await _httpClient.GetAsync(new Uri(_baseUri, _apiOptions.Card.GetAllCardsPath));
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<List<SimpleCardResponse>>();
            var asd = new CardListResponse { Cards = result };
            return asd;
        }

        public async Task<CardByIdResponse> GetCardById(GetCardByIdRequest request)
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authenticationService.Token}");
            var response = await _httpClient.GetAsync(new Uri(_baseUri, _apiOptions.Card.GetCardByIdPath));
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<CardByIdResponse>();
            return result;
        }

        public async Task UpdateCard(UpdateCardRequest request)
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authenticationService.Token}");
            var response = await _httpClient.PutAsJsonAsync(new Uri(_baseUri, _apiOptions.Card.UpdateCardPath), request);
            response.EnsureSuccessStatusCode();
        }
    }
}