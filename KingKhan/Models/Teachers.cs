using System.ComponentModel.DataAnnotations;

namespace KingKhan.Models
{
    public class Teachers
    {
        [Key]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
    }
}
