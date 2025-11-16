using System;

namespace Homeworkz.Models
{
    public class UsersRoles
    {

        public int UserId { get; set; }
        public required Users User { get; set; }

        public int RoleId { get; set; }
        public required Roles Rol {  get; set; } 

    }
}
