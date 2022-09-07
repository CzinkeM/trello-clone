using System.Text.Json.Serialization;

namespace WebApp.Models.Requests.UserRequest
{
    public class SignUpRequest
    {
        public SignUpRequest(string email, string password)
        {
            Email = email;
            Password = password;
        }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
