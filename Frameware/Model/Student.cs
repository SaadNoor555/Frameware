using System.ComponentModel.DataAnnotations;

namespace Frameware.Model
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public double Cgpa { get; set; }
    }
}
