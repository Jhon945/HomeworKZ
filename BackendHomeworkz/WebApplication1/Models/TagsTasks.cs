using System;
using System.ComponentModel.DataAnnotations;

namespace Homeworkz.Models
{
    public class TagsTasks
    {

        [Required]
        public int TaskId { get; set; }
        public Tasks Task { get; set; } = null!;

        [Required]
        public int TagId { get; set; }
        public Tags Tag { get; set; } = null!;

    }
}
