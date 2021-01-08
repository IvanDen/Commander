using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandReadDto : CommandDtoBase
    {
        public int Id { get; set; }       
        public override string HowTo { get; set; }
        
        public override string Line { get; set; }
    }
}
