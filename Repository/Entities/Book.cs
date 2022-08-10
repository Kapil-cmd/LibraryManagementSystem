namespace Repository.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UploadedBy { get; set; }
        public string CategoryName { get; set; }
        public string AuthorName { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual IEnumerable<User> AssignedUser { get; set; }
        public IEnumerable <Author> Author { get; set; }
    }
}
