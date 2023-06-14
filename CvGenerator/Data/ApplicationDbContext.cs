using CvGenerator.Models;
using Microsoft.EntityFrameworkCore;

namespace CvGenerator.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
         public DbSet<User> Users { get; set; }
        public DbSet<Skills> Skill { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<References> Reference { get; set; }
        public DbSet<CertificationAndTraining> CertificationAndTrainings { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<All> All { get; set; }
    }
    }
