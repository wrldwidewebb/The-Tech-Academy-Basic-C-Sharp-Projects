using System.ComponentModel.DataAnnotations;


namespace CodeFirsts.Models
{
   public class Instructor
    
    {
        [Key]
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentId { get; set; }
    }
}
