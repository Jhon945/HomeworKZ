using Homeworkz.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.DTOs.ProjectsMembers
{
    public class ProjectsMembersCreateDto
    {

        [Required]
        public int ProjectId { get; set; }

        [Required]
        public ProjectMembersRoles RolProject { get; set; }

        [Required]
        public int UserId { get; set; }

    }
}
