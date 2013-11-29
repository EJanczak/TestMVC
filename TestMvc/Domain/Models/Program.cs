using System.ComponentModel.DataAnnotations.Schema;

namespace TestMvc.Domain.Models
{
    [Table("Program", Schema="Programs")]
    public class Program : EntityBase
    {        
        public string Name { get; set; }

    }
}