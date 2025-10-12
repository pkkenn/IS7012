using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Models;

namespace EventManagement.Pages.Attendees
{
    public class IndexModel : PageModel
    {
        private readonly EventManagement.Data.EventManagementContext _context;

        public IndexModel(EventManagement.Data.EventManagementContext context)
        {
            _context = context;
        }

        public IList<Attendee> Attendee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Attendee = await _context.Attendees.ToListAsync();
        }
    }
}
