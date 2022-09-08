namespace WebApp.Models.Requests.CardRequest
{
    public class GetCardByIdRequest
    {
        public GetCardByIdRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
