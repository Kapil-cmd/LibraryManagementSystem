namespace Repository.Entities
{
    public class RolePermission
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public virtual Role aRole { get; set; }
        public virtual Permission aPermission { get; set; }
    }
}
