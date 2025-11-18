using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkz.Aplication.DTOs.Tags
{
    public class TagsUpdateDto
    {

        [Required]
        public string Name { get; set; } = string.Empty;

        [StringLength(150)]
        public string Color { get; set; } = string.Empty;

    }
}
