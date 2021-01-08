
using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos 
{
    public class CommandDtoBase 
    {
        [Required]
        [MaxLength(250)]
        public virtual string HowTo { get; set; }
        
        [Required]        
        public virtual string Line { get; set; }
    }
}