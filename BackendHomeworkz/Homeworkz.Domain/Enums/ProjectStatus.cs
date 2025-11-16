using System;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Domain.Enums
{
    public enum ProjectStatus
    {
        // El proyecto ha sido creado correctamente
        [Display(Name = "Created")]
        Created = 1,

        // El proyecto se encuentra en desarrollo
        [Display(Name = "In Progress")]
        InProgress = 2,

        // El proyecto ha sido completado en su totalidad(ha finalizado el proyecto)
        [Display(Name = "Complete")]
        Complete = 3,

        // El proyecto ua sido archivado(no seguira en produccion o esta en pausa)
        [Display(Name = "Archived")]
        Archived = 4

    }
}
