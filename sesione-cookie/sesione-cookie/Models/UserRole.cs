namespace sesione_cookie.Models
{
    public class UserRole: BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;


        public Guid RoleId { get; set; }
        public Role Role { get; set; } = null!;
        //con "null!" le decimos al controlador que posiblemete sea nulo. Así no nos pone advertencia
    }
}
