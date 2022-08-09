namespace Repository.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }

        public virtual User User { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
