using Homeworkz.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.DTOs.ProjectsMembers
{
    public class ProjectsMembersGetDto
    {

        public int Id { get; set; }

        public int ProjectId { get; set; }

        public ProjectMembersRoles RolProject { get; set; }

        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        public DateTime? LeftAt { get; set; }

        public int UserId { get; set; }

    }
}
