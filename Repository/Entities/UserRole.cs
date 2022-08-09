namespace Repository.Entities
{
    public class UserRole
    {
        public int RoleId { get; set; }
        public string UserId { get; set; }

        public virtual User aUser { get; set; }
        public virtual Role aRole { get; set; }
    }
}
