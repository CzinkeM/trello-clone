namespace WebApp.Models.Responses.CardResponse
{
    public class SimpleCardResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int Position { get; set; }

    }
}
