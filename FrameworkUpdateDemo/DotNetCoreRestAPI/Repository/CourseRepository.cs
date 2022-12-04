using DotNetCoreRestAPI.Models.Db;

namespace DotNetCoreRestAPI.Repository
{
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(ApplicaitonDbContext dbContext) : base(dbContext)
        {
        }
    }
}
