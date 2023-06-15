using CvGenerator.Models;
using CvGenerator.Repositories;
using CvGenerator.Repository;
using CvGenerator.Repository.CertificationAndTraining;
using CvGenerator.Repository.Description;
using CvGenerator.Repository.Education;
using CvGenerator.Repository.References;
using CvGenerator.Repository.WorkExperience;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        
        public AllController(ISkillRepository skillRepository, IUserRepository usersRepository, IEducationRepository educationRepository, IDescriptionRepository descriptionsRepository,
            IWorkExperienceRepository workExperiencesRepository, ICertificationAndTrainingRepository certificationsAndTrainingRepository, IReferenceRepository referencesRepository)
        {
            _skillsRepository = skillRepository;
            _userRepository = usersRepository;
            _certificationAndTrainingRepository = certificationsAndTrainingRepository; 
            _referenceRepository = referencesRepository;
            _descriptionRepository = descriptionsRepository;
            _educationRepository = educationRepository;
            _workExperienceRepository = workExperiencesRepository;

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
    }
}