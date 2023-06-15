using System.ComponentModel.DataAnnotations;

namespace CvGenerator.Models
{
    public class Descriptions
    {
        [Key]
        public int Id{get; set;}
        public string Des { get; set;}
    }
}
