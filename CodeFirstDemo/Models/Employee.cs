using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDemo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }

        [Required]
        public decimal Salary { get; set; }

        // string? City { get; set; }
        //when we want to drop col we jusr need comment it

        [ForeignKey("DeptId")]
        public int DeptId { get; set; }
    }
}
