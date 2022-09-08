namespace WebApp.Models
{
    public class SimpleCard
    {
        public SimpleCard(Guid id, string title, string description, CardStatus status, int position)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = status;
            Position = position;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CardStatus Status { get; set; }
        public int Position { get; set; }
    }
}