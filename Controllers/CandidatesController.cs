using Microsoft.AspNetCore.Mvc;
using JobCandidatesApi.Data;
using JobCandidatesApi.Models;
using System.Threading.Tasks;

namespace JobCandidatesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly JobCandidatesContext _context;

        public CandidatesController(JobCandidatesContext context)
        {
            _context = context;
        }

        // POST: api/Candidates
        [HttpPost]
        public async Task<IActionResult> PostCandidate([FromBody] Candidate candidate)
        {
            if (candidate == null)
                return BadRequest();

            _context.Candidates.Add(candidate);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(PostCandidate), new { id = candidate.Id }, candidate);
        }
    }
}
