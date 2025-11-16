using System;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Enums
{
    public enum StatusTask
    {

        // La tarea esta creada pero no ha sido asignada ni priorizada
        [Display(Name = "Backlog")]
        Blacklog = 0,

        // La tarea ya fue asignada pero no han comenzado con su desarrollo
        [Display(Name = "Pending")]
        Pending = 1,

        // La tarea esta en desarrollo
        [Display(Name = "In Progress")]
        InProgress = 2,

        // La tarea esta en proceso de revision
        [Display(Name = "In Review")]
        InReview = 3,

        // La tarea ha sido blockeada o cancelada
        [Display(Name = "Block")]
        Blocked = 4,

        // La tarea ha sido completada satisfactoriamente
        [Display(Name = "Done")]
        Done = 5,

    }
}
