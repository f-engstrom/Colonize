using System.Collections.Generic;
using System.Linq;
using Colonize.Data;
using Colonize.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Colonize.Areas.Admin.Pages.Ships
{
    public class IndexModel : PageModel
    {
        private readonly ColonizeContext _context;

        public IEnumerable<Ship> Ships { get; set; }

        public IndexModel(ColonizeContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Ships = _context.Ship.ToList();
        }
    }
}