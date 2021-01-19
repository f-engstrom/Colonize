using System.Collections.Generic;
using System.Linq;
using Colonize.Data;
using Colonize.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Colonize.Areas.Admin.Pages.Destinations
{
    public class IndexModel : PageModel
    {
        private readonly ColonizeContext _context;

        public IEnumerable<Voyage> Voyages { get; set; }

        public IndexModel(ColonizeContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Voyages = _context.Voyage.ToList();
        }
    }
}