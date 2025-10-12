using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace EventManagement.Pages.UpcomingEvents
{
    public class UpcomingEventsModel : PageModel
    {
        private readonly EventManagementContext _context;

        public UpcomingEventsModel(EventManagementContext context)
        {
            _context = context;
        }

        public IList<Event> Events { get; set; } = new List<Event>();

        public async Task OnGetAsync()
        {
            Events = await _context.Events
                .Include(e => e.Organizer)
                .Where(e => e.Date >= DateTime.Now)
                .OrderBy(e => e.Date)
                .ToListAsync();
        }
    }
}

