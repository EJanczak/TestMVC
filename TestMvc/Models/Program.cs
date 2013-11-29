using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace TestMvc.Models
{
    [Table("Program", Schema="Programs")]
    public class Program
    {
        public int Id { get; set; } 

        public string Name { get; set; }

    }
}