using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Portfolio
{
    [Route("projects")]
    [ApiController]
    public class ProjectsController : Controller
    {
        private readonly PortfolioContext _db;

        public ProjectsController(PortfolioContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetProjects()
        {
            return (await _db.Projects.ToListAsync()).ToList();
        }
    }
}