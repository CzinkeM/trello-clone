using System.Text.Json.Serialization;

namespace WebApp.Models.Requests.CardRequest
{
    public class DeleteCardRequest
    {
        public DeleteCardRequest(Guid id)
        {
            Id = id;
        }

        [JsonPropertyName("Id")]
        public Guid Id { get; set; }
    }
}
