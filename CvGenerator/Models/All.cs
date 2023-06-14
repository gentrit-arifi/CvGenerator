using System.ComponentModel.DataAnnotations;

namespace CvGenerator.Models
{
    public class All
    {
        [Key]
        public int Id { get; set; }
        //public List<User> Users { get; set; }
        //public List<CertificationAndTraining> CertificationAndTrainings { get; set; }
        //public List<References> Reference { get; set; }
        //public List<Education> Educations { get; set; }
        //public List<Skills> Skill { get; set; }
        //public List<Description> Descriptions { get; set; }
        //public List<WorkExperience> WorkExperiences { get; set; }
        public IEnumerable<Skills> Skills { get; internal set; }
        public IEnumerable<User> User { get; internal set; }
    }
}
