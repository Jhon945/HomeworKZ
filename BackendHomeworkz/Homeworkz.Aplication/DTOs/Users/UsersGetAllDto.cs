using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.DTOs.Users
{
    internal class UsersGetAllDto
    {

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Lastname { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty; //hay que dejarlo hash

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
