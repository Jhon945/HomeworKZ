using System;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Domain.Enums
{
    public enum PriorityTask
    {

        [Display(Name = "Low")]
        Low = 1,

        [Display(Name = "Medium")]
        medium = 2,

        [Display(Name = "High")]
        High = 3,

        [Display(Name = "Critical")]
        Critical = 4,
    }
}
