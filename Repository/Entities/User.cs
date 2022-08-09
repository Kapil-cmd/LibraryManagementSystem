namespace Repository.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }   
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<UserRole> Roles { get; set; }
        public IEnumerable<UserBook> AssignedBook { get; set; } 
    }
}
