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
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<Users> User { get; set; }
        public IEnumerable<WorkExperiences> WorkExperience { get; set; }
        public IEnumerable<Educations> Education { get; set; }
        public IEnumerable<Reference> References { get; set; }
        public IEnumerable<Descriptions> Description { get; set; }
        public IEnumerable<CertificationAndTrainings> CertificationAndTraining { get; set; }

        public Users users { get; set; }
        public CertificationAndTrainings certificationAndTrainings { get; set; }
        public Skill skill { get; set; }
        public Educations educations { get; set; }
        public Reference reference { get; set; }
        public Descriptions descriptions { get; set; }
        public WorkExperiences workExperiences { get; set; }

    }
}
