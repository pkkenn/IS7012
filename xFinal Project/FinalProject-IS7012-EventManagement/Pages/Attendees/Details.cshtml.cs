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
    public class DetailsModel : PageModel
    {
        private readonly EventManagement.Data.EventManagementContext _context;

        public DetailsModel(EventManagement.Data.EventManagementContext context)
        {
            _context = context;
        }

        public Attendee Attendee { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attendee = await _context.Attendees.FirstOrDefaultAsync(m => m.Id == id);

            if (attendee is not null)
            {
                Attendee = attendee;

                return Page();
            }

            return NotFound();
        }
    }
}
