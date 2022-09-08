namespace WebApp.Models.Responses.CardResponse
{
    public class CardByIdResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int position { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string OwnerId { get; set; }
        public string AsigneeId { get; set; }
    }
}
