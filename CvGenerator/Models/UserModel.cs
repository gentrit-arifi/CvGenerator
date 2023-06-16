using System.ComponentModel.DataAnnotations;

namespace CvGenerator.Models
{
    public class UserReportModel
    {
 
        public int Id { get; set; }
    
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public DateTime BirthDate { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }
     
        public string Address { get; set; }
        public string SkillN { get; set; }
        public string SkillD { get; set;}
        public string WorkT { get; set; }
        public string Company { get; set; }
        public DateTime WorkStart { get; set; }
        public DateTime WorkEnd { get; set; }
        public string Responsibilities { get; set; }
        public string ReferenceN { get; set;}
        public string ReferenceC { get; set; }
        public string ReferenceD { get; set; }
        public string EducationN { get; set; }
        public string EducationF { get;set; }
        public string EducationStart { get; set; }
        public string EducationEnd { get; set; }
        public double Grade { get; set; }
        public string Des { get; set; }
        public string CerN { get; set; }
        public string CerC { get; set; }    

        public DateTime CerDate { get; set;}
    }
}
