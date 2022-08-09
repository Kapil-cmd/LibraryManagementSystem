namespace Repository.Entities
{
    public class Author
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Address { get; set; }

        public IEnumerable<Book> Books { get; set; }
    }
}
