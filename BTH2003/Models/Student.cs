using System.ComponentModel.DataAnnotations;
namespace BTH2003.Models
{
    public class Student
    {
        [Table("Student")]
        [key]
        public string StudentID{get; set; }
        public string StudentName{get; set; }
    }
}