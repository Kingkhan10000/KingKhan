using System.ComponentModel.DataAnnotations;

namespace KingKhan.Models
{
    public class Parents
    {
        [Key]
        public int ParentId { get; set; }
        public string ParentName { get; set; }
        public string ParentEmail { get; set; }
    }
}
