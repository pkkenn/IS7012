using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.Pages.Events
{
    public class SearchModel : PageModel
    {
        private readonly EventManagementContext _context;

        public SearchModel(EventManagementContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string? Query { get; set; }

        [BindProperty(SupportsGet = true)]
        public DateTime? Date { get; set; }

        public IList<Event> Events { get; set; } = new List<Event>();

        public async Task OnGetAsync()
        {
            var results = _context.Events
                .Include(e => e.Organizer)
                .AsQueryable();

            if (!string.IsNullOrEmpty(Query))
            {
                results = results.Where(e =>
                    e.Title.Contains(Query) ||
                    (e.Location != null && e.Location.Contains(Query)));
            }

            if (Date.HasValue)
            {
                results = results.Where(e => e.Date.Date == Date.Value.Date);
            }

            Events = await results.ToListAsync();
        }
    }
}

