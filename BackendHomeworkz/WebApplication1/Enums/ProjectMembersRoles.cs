using System;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Enums
{
    public enum ProjectMembersRoles
    {

        // EL creador del proyecto podra ver avances y cambios del proyecto, ademas podran gestionar tareas y usuarios
        [Display(Name = "Owner")]
        Owner = 1,

        // El admin podra gestionar tareas y unicamente gestinoar a los member del project
        [Display(Name = "Admin Project")]
        AdminProject = 2,

        // El member solo podran visualizar las tareas para completarlas
        [Display(Name = "Member")]
        Member = 3,
    }
}
