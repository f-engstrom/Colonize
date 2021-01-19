using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colonize.Data;
using Colonize.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Colonize.Pages
{
    public class VoyageModel : PageModel
    {

        public Voyage Voyage { get; set; }
        private readonly ILogger<VoyageModel> _logger;
        private readonly ColonizeContext _context;

        public IEnumerable<Voyage> Ships { get; set; }

        public VoyageModel(ColonizeContext context, ILogger<VoyageModel> logger)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult OnGet(int id)
        {
            Voyage = _context.Voyage.Include(x => x.Ship).Include(x => x.Passengers).FirstOrDefault(x => x.Id == id);

            if (Voyage == null)
            {
                return NotFound();
            }

            return Page();


        }
    }
}
