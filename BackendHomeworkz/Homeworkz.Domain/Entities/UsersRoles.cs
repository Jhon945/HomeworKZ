using System;

namespace Homeworkz.Domain.Entities
{
    public class UsersRoles
    {

        public int UserId { get; set; }
        public required Users User { get; set; }

        public int RoleId { get; set; }
        public required Roles Rol {  get; set; } 

    }
}
