using System.ComponentModel.DataAnnotations;

namespace CvGenerator.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Field { get; set; }
        [Required]
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public double Grade { get; set; }
    }
}
