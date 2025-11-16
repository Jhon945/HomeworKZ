using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Domain.Entities
{

    [Index(nameof(Rol), IsUnique = true)]

    public class Roles
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Rol { get; set; } = string.Empty;



        // Relacion N-N UsersRoles
        public ICollection<UsersRoles> UsersRoles { get; set; } = new List<UsersRoles>();
        // Relacion N-N RolesPermissions
        public ICollection<RolesPermissions> RolesPermissions { get; set; } = new List<RolesPermissions>();

    }
}
