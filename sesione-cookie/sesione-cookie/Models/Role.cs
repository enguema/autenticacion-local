namespace sesione_cookie.Models
{
    public class Role: BaseEntity
    {
        public string Nombre { get; set; } = string.Empty;

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
