using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos 
{
    public class CommandCreateDto : CommandDtoBase
    {
        [Required]        
        public string Platform { get; set; }
    }
}