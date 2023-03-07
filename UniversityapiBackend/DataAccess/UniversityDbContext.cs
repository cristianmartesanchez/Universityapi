using Microsoft.EntityFrameworkCore;
using UniversityapiBackend.Models.DataModels;

namespace UniversityapiBackend.DataAccess
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {

        }

        // Add DbSets
        public DbSet<User> Users { get; set; }

    }
}
