using Microsoft.EntityFrameworkCore;
using JobCandidatesApi.Models;

namespace JobCandidatesApi.Data
{
    public class JobCandidatesContext : DbContext
    {
        public JobCandidatesContext(DbContextOptions<JobCandidatesContext> options)
            : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }
    }
}
