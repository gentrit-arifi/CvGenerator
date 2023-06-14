using CvGenerator.Models;
using CvGenerator.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CvGenerator.Controllers
{
    public class AllController : Controller
    {
        private readonly ISkillsRepository _skillsRepository;
        private readonly IUserRepository _userRepository;

        public AllController(ISkillsRepository skillsRepository, IUserRepository usersRepository)
        {
            _skillsRepository = skillsRepository;
            _userRepository = usersRepository;
        }

        public IActionResult CombinedView()
        {
            var skills = _skillsRepository.GetAllSkills();
            var users = _userRepository.GetAllUsers();

            var viewModel = new All
            {
                Skills = skills,
                User = users
            };

            return View(viewModel);
        }
    }
}