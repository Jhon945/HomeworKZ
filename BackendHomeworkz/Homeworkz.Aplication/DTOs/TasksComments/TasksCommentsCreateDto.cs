using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.DTOs.TasksComments
{
    public class TasksCommentsCreateDto
    {

        [Required]
        public string Comment { get; set; } = string.Empty;

        [Required]
        public int TaskId { get; set; }

        [Required]
        public int UserId { get; set; }

    }
}
