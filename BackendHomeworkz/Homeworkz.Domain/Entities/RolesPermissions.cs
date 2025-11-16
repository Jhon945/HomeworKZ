using System;

namespace Homeworkz.Domain.Entities
{
    public class RolesPermissions
    {

        public int RoleId { get; set; }
        public required Roles Rol { get; set; } 

        public int PermissionId { get; set; }
        public required Permissions Permission { get; set; } 
    }
}
