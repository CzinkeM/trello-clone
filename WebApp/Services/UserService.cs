using Microsoft.Extensions.Options;
using WebApp.Models.Requests.UserRequest;
using WebApp.Models.Responses.UserResponse;
using WebApp.Settings;

namespace WebApp.Services
{
    public class UserService : IUserService
    {
        private readonly ApiOptions _apiOptions;
        private readonly HttpClient _httpClient;
        private readonly AuthenticationService _authenticationService;
        private readonly Uri baseUri;

        public UserService(IOptions<ApiOptions> apiOptions, HttpClient httpClient, AuthenticationService authenticationService)
        {
            _apiOptions = apiOptions.Value;
            _httpClient = httpClient;
            _authenticationService = authenticationService;
            baseUri = new Uri(_apiOptions.BaseUri);
            _httpClient.BaseAddress = baseUri;
        }

        public string Token { get; set; }

        public async Task<string> ListAllUsers()
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {Token}");
            var result = await _httpClient.GetAsync(new Uri(baseUri, _apiOptions.User.GetAllUser));
            return result.Content.ToString();
        }

        public async Task<SignInResponse> SignIn(SignInRequest request)
        {
            var uri = new Uri(baseUri, _apiOptions.User.SignInPath);
            var jsonResponse = await _httpClient.PostAsJsonAsync(uri, request);
            jsonResponse.EnsureSuccessStatusCode();
            var response = await jsonResponse.Content.ReadFromJsonAsync<SignInResponse>();
            _authenticationService.Token = response.Token ?? "";
            return response;
        }

        public async Task SignUp(SignUpRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync(new Uri(baseUri, _apiOptions.User.SignUpPath), request);
            response.EnsureSuccessStatusCode();
        }
    }
}