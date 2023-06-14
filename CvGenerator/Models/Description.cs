using System.ComponentModel.DataAnnotations;

namespace CvGenerator.Models
{
    public class Description
    {
        [Key]
        public int DescriptionId{get; set;}
        public string Des { get; set;}
    }
}
