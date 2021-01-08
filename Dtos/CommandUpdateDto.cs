using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos 
{
    public class CommandUpdateDto : CommandDtoBase
    {
        [Required]        
        public string Platform { get; set; }
    }
}