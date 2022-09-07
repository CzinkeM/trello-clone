using System.Text.Json.Serialization;

namespace WebApp.Models.Responses.UserResponse
{
    public class UserResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
