using Microsoft.AspNetCore.Mvc;
using JobCandidatesApi.Data;
using JobCandidatesApi.Models;
using System.Linq;
using System.Threading.Tasks;

namespace JobCandidatesApi.Controllers
{
    public class CandidateController : Controller
    {
        private readonly JobCandidatesContext _context;

        public CandidateController(JobCandidatesContext context)
        {
            _context = context;
        }

        // GET: Candidate/Index
        public IActionResult Index()
        {
            var candidates = _context.Candidates.ToList();
            return View(candidates); // Returns the Index view with a list of candidates
        }

        // GET: Candidate/Create
        public IActionResult Create()
        {
            return View(); // Returns the Create view with a form to add a new candidate
        }

        // POST: Candidate/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Candidate candidate)
        {
            if (ModelState.IsValid)
            {
                _context.Candidates.Add(candidate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); // Redirects to Index view after creating a candidate
            }
            return View(candidate); // Returns the form view with validation messages if model state is invalid
        }

        // GET: Candidate/Details/5
        public IActionResult Details(int id)
        {
            var candidate = _context.Candidates.FirstOrDefault(c => c.Id == id);
            if (candidate == null)
            {
                return NotFound();
            }
            return View(candidate); // Returns the Details view with information about a specific candidate
        }
    }
}
