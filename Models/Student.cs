using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDusingEFJisaHW.Models
{
    [Table("Student")]
    public class Student
    {
        [Key] 
        public int Id { get; set; }
        [Required]

        public string? Name { get; set; }
        [Required]

        public string? Grade { get; set; }
        [Required]

        public string? City { get; set; }

    }
}
