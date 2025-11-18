using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.DTOs.TasksComments
{
    internal class TasksCommentsUpdateDto
    {

        [Required]
        public string Comment { get; set; } = string.Empty;

    }
}
