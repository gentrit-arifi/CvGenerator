using CvGenerator.Models;
using Microsoft.EntityFrameworkCore;

namespace CvGenerator.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
         public DbSet<Users> Users { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Educations> Educations { get; set; }
        public DbSet<Reference> Reference { get; set; }
        public DbSet<CertificationAndTrainings> CertificationAndTrainings { get; set; }
        public DbSet<Descriptions> Descriptions { get; set; }
        public DbSet<WorkExperiences> WorkExperiences { get; set; }
        public DbSet<All> All { get; set; }
    }
    }
