using Homeworkz.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.DTOs.ProjectsMembers
{
    internal class ProjectsMembersUpdateDto
    {

        [Required]
        public ProjectMembersRoles RolProject { get; set; }

        public DateTime? LeftAt { get; set; }

    }
}
