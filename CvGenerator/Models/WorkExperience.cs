using System.ComponentModel.DataAnnotations;

namespace CvGenerator.Models
{
    public class WorkExperience
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public string Responsibilities { get; set; }
    }
}
