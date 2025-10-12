using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Models;
using Microsoft.AspNetCore.Authorization;

namespace EventManagement.Pages.Organizer
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly EventManagement.Data.EventManagementContext _context;

        public DeleteModel(EventManagement.Data.EventManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var organizer = await _context.Organizers.FindAsync(id);
            if (organizer != null)
            {
                Organizer = organizer;
                _context.Organizers.Remove(Organizer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
