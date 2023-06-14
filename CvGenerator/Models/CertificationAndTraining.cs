using System.ComponentModel.DataAnnotations;

namespace CvGenerator.Models
{
    public class CertificationAndTraining
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public DateTime IssueDate { get; set; }
    }
}
