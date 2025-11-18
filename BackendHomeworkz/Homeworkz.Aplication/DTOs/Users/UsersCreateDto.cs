using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.DTOs.Users
{
    internal class UsersCreateDto
    {

        [Required, StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(150)]
        public string Lastname { get; set; } = string.Empty;

        [Required, EmailAddress, StringLength(200)]
        public string Email { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Phone { get; set; } = string.Empty;

        [Required, StringLength(200)]
        public string Username { get; set; } = string.Empty;

        [Required, StringLength(150)]
        public string Password { get; set; } = string.Empty; //hay que dejarlo hash

    }
}
