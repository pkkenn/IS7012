using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Models;

namespace EventManagement.Pages.Events
{
    public class IndexModel : PageModel
    {
        private readonly EventManagementContext _context;

        public IndexModel(EventManagementContext context)
        {
            _context = context;
        }

        public IList<EventManagement.Models.Event> Events { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Events = await _context.Events
                .Include(e => e.Organizer)
                .ToListAsync();
        }
    }
}
