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
    public class DetailsModel : PageModel
    {
        private readonly EventManagement.Data.EventManagementContext _context;

        public DetailsModel(EventManagement.Data.EventManagementContext context)
        {
            _context = context;
        }

        public EventManagement.Models.Organizer Organizer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organizer = await _context.Organizers.FirstOrDefaultAsync(m => m.Id == id);
            if (organizer == null)
            {
                return NotFound();
            }
            else
            {
                Organizer = organizer;
            }
            return Page();
        }
    }
}
