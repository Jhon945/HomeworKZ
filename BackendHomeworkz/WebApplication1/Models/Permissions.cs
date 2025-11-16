using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Models
{

    [Index(nameof(Permission), IsUnique = true)]

    public class Permissions
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Permission { get; set; } = string.Empty;


        //Realacion N-N RolesPermission
        public ICollection<RolesPermissions> RolesPermissions { get; set; } = new List<RolesPermissions>();
    }
}
