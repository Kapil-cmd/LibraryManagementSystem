namespace Repository.Entities
{
    public class UserBook
    {
        public int BookId { get; set; }
        public int UserId { get; set; }

        public virtual Book aBook { get; set; }
        public virtual User aUser { get; set; }
    }
}
