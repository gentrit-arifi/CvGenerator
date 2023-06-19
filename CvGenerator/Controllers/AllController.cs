using CvGenerator.Data;
using CvGenerator.Models;
using CvGenerator.Repositories;
using CvGenerator.Repository;
using CvGenerator.Repository.CertificationAndTraining;
using CvGenerator.Repository.Description;
using CvGenerator.Repository.References;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvGenerator.Controllers
{
    public class AllController : Controller
    {
        private readonly ISkillRepository _skillsRepository;
        private readonly IUserRepository _userRepository;
        private readonly IEducationRepository _educationRepository;
        private readonly IDescriptionRepository _descriptionRepository;
        private readonly IWorkExperienceRepository _workExperienceRepository;
        private readonly ICertificationAndTrainingRepository _certificationAndTrainingRepository;
        private readonly IReferenceRepository _referenceRepository;
        private readonly ApplicationDbContext _db;

        public AllController(
            ISkillRepository skillRepository,
            IUserRepository userRepository,
            IEducationRepository educationRepository,
            IDescriptionRepository descriptionRepository,
            IWorkExperienceRepository workExperienceRepository,
            ICertificationAndTrainingRepository certificationAndTrainingRepository,
            IReferenceRepository referenceRepository,
            ApplicationDbContext db)
        {
            _skillsRepository = skillRepository;
            _userRepository = userRepository;
            _educationRepository = educationRepository;
            _descriptionRepository = descriptionRepository;
            _workExperienceRepository = workExperienceRepository;
            _certificationAndTrainingRepository = certificationAndTrainingRepository;
            _referenceRepository = referenceRepository;
            _db = db;
        }

        public IActionResult Index()
        {
            var skills = _skillsRepository.GetAllSkills();
            var users = _userRepository.GetAllUsers();
            var edu = _educationRepository.GetAllEdu();
            var description = _descriptionRepository.GetAllDes();
            var cer = _certificationAndTrainingRepository.GetAllCer();
            var refe = _referenceRepository.GetAllRef();
            var work = _workExperienceRepository.GetAllExp();

            var viewModel = new All
            {
                Skills = skills,
                User = users,
                Education = edu,
                Description = description,
                CertificationAndTraining = cer,
                References = refe,
                WorkExperience = work,
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<JsonResult> OpenIndexReport()
        {
            var all = _db.All.ToList();
            var users = _db.Users.ToList();
            var works = _db.WorkExperiences.ToList();
            var certifications = _db.CertificationAndTrainings.ToList();
            var skills = _db.Skill.ToList();
            var description = _db.Descriptions.ToList();
            var edu = _db.Educations.ToList();
            var refe = _db.Reference.ToList();

            var query = all
                .Select(q => new UserReportModel
                {
                    Id = q.Id,
                    FirstName = q.users.FirstName,
                    LastName = q.users.LastName,
                    BirthDate = q.users.BirthDate,
                    Address = q.users.Address,
                    Email = q.users.Email,
                    PhoneNumber = q.users.PhoneNumber,
                    SkillN = q.skill.Name,
                    SkillD = q.skill.Description,
                    WorkT = q.workExperiences.Title,
                    Company = q.workExperiences.Company,
                    WorkStart = q.workExperiences.StartDate,
                    WorkEnd = q.workExperiences.EndDate,
                    Responsibilities = q.workExperiences.Responsibilities,
                    ReferenceN = q.reference.Name,
                    ReferenceC = q.reference.Contact,
                    ReferenceD = q.reference.Description,
                    EducationN = q.educations.Name,
                    EducationStart = q.educations.StartDate,
                    EducationEnd = q.educations.EndDate,
                    Grade = q.educations.Grade,
                    Des = q.descriptions.Des,
                    CerN = q.certificationAndTrainings.Name,
                    CerC = q.certificationAndTrainings.Company,
                    CerDate = q.certificationAndTrainings.IssueDate
                }).ToList();

            var serializedQuery = JsonConvert.SerializeObject(query);
            var queryBytes = Encoding.UTF8.GetBytes(serializedQuery);

            HttpContext.Session.SetString("Path", "Reports\\UserReport.rdl");
            HttpContext.Session.Set("queryresult", queryBytes);

            return Json(true);
        }
    }
}
