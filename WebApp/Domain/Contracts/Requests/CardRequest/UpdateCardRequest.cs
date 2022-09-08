using System.Text.Json.Serialization;

namespace WebApp.Models.Requests.CardRequest
{
    public class UpdateCardRequest
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("asigneeId")]
        public Guid AsigneeId { get; set; }
    }
}
