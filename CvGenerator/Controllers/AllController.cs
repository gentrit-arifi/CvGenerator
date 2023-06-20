using CvGenerator.Data;
using CvGenerator.Helpers;
using CvGenerator.Models;
using CvGenerator.Models.Session;
using CvGenerator.Repositories;
using CvGenerator.Repository;
using CvGenerator.Repository.CertificationAndTraining;
using CvGenerator.Repository.Description;
using CvGenerator.Repository.References;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using System.Drawing;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.ReportingServices.Interfaces;

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
     
            var users = _db.Users.ToList();
            var work = _db.WorkExperiences.ToList();
            var cer = _db.CertificationAndTrainings.ToList();
            var skills = _db.Skill.ToList();
            var description = _db.Descriptions.ToList();
            var edu = _db.Educations.ToList();
            var refe = _db.Reference.ToList();

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
        public async Task<IActionResult> OpenIndexReport(ReportType type)
        {
            var skill = await _db.Skill.Select(t => new
            {
                Name = t.Name,
                Description = t.Description
            }).ToListAsync();
            var des = await _db.Descriptions.Select(t => new
            {
                Des = t.Des,
            }).ToListAsync();
            var user = await _db.Users.Select(t => new
            {
                FirstName = t.FirstName,
                LastName = t.LastName,
                PhoneNumber = t.PhoneNumber,
                Address = t.Address,
                BirthDate = t.BirthDate,
                Email = t.Email
            }).ToListAsync();
            var cer = await _db.CertificationAndTrainings.Select(t => new
            {
                Name = t.Name,
                Company = t.Company,
                IssueDate = t.IssueDate
            }).ToListAsync();
            var edu = await _db.Educations.Select(t => new
            {
                Name = t.Name,
                Field = t.Field,
                StartDate = t.StartDate,
                EndDate = t.EndDate,
                Grade = t.Grade
            }).ToListAsync();

            var refe = await _db.Reference.Select(t => new
            {
                Name = t.Name,
                Contact = t.Contact,
                Description = t.Description
            }).ToListAsync();

            var exp = await _db.WorkExperiences.Select(t => new
            {
                Title = t.Title,
                Company = t.Company,
                StartDate = t.StartDate,
                EndDate = t.EndDate,
                Responsibilities = t.Responsibilities
            }).ToListAsync();


            RDCLReport rdlc = new RDCLReport();

            List<ReportDataSource> ds = new() { 
                new ReportDataSource("DataSet1", skill),
                new ReportDataSource("DataSet2", des),
                new ReportDataSource("DataSet3", exp),
                new ReportDataSource("DataSet4", refe),
                new ReportDataSource("DataSet5", edu),
                new ReportDataSource("DataSet6", user),
                new ReportDataSource("DataSet7", cer)
            };
            List<ReportParameter> parameters = new(){ };

            var FinalReport = rdlc.GenerateReport("Skills.rdl", type, ds, parameters, "8.27in", "11.67in");
            return type == ReportType.PDF ? File(FinalReport, "application/pdf") : File(FinalReport, "application/ms-excel", "Raporti.xlsx");
        }
    }
}