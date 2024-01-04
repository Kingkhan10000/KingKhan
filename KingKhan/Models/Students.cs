using System.ComponentModel.DataAnnotations;

namespace KingKhan.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }

    }
}
