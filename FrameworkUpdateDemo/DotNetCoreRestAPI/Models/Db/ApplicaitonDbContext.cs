using Microsoft.EntityFrameworkCore;

namespace DotNetCoreRestAPI.Models.Db
{
    public class ApplicaitonDbContext : DbContext
    {
        public ApplicaitonDbContext(DbContextOptions<ApplicaitonDbContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}
