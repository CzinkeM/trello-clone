using System.Text.Json.Serialization;

namespace WebApp.Models.Requests.CardRequest
{
    public class CreateCardRequest
    {
        public CreateCardRequest(string title, string description)
        {
            Title = title;
            Description = description;
        }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
