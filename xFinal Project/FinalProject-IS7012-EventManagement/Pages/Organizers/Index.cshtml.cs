using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Models;

namespace EventManagement.Pages.Organizer
{
    public class IndexModel : PageModel
    {
        private readonly EventManagement.Data.EventManagementContext _context;

        public IndexModel(EventManagement.Data.EventManagementContext context)
        {
            _context = context;
        }

        public IList<EventManagement.Models.Organizer> Organizer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Organizer = await _context.Organizers.ToListAsync();
        }
    }
}
