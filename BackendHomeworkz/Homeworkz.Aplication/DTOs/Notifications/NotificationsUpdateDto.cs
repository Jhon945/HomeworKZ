using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.DTOs.Notifications
{
    internal class NotificationsUpdateDto
    {

        [Required]
        public string Message { get; set; } = string.Empty;

    }
}
