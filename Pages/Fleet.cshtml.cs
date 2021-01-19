using System.Collections.Generic;
using System.Linq;
using Colonize.Data;
using Colonize.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Colonize.Pages
{
    public class FleetModel : PageModel
    {
        private readonly ILogger<FleetModel> _logger;
        private readonly ColonizeContext _context;

        public IEnumerable<Ship> Ships { get; set; }

        public FleetModel(ColonizeContext context, ILogger<FleetModel> logger)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            Ships = _context.Ship.ToList();
        }
    }
}
