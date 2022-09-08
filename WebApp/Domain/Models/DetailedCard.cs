namespace WebApp.Models
{
    public class DetailedCard : SimpleCard
    {
        public DetailedCard(
            Guid id,
            string title,
            string description,
            CardStatus status,
            int position,
            DateTime createdAt,
            DateTime modifiedAt,
            Guid ownerId,
            Guid asigneeid)
            : base(id, title, description, status, position)
        {
            CreatedAt = createdAt;
            ModifiedAt = modifiedAt;
            OwnerId = ownerId;
            Asigneeid = asigneeid;
        }

        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Guid OwnerId { get; set; }
        public Guid Asigneeid { get; set; }
    }
}