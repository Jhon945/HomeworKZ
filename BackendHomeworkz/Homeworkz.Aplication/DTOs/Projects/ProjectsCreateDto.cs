using Homeworkz.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.DTOs.Projects
{
    public class ProjectsCreateDto
    {

        [Required, StringLength(300)]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public ProjectStatus Status { get; set; } = ProjectStatus.Created;

    }
}
