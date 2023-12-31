using Microsoft.EntityFrameworkCore;
 
namespace OnlineAssessment.Models
{
    public class OnlineAssessmentContext : DbContext
    {
        //private DbSet<Candidate> candidates;

        public OnlineAssessmentContext(DbContextOptions<OnlineAssessmentContext> options) : base(options)
        {

        }
        public DbSet<Question>? Questions { get; set; }
        public DbSet<Candidate>? Candidates { get; set; }
    }
}
