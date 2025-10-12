using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Models;
using Microsoft.AspNetCore.Authorization;

namespace EventManagement.Pages.Events
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly EventManagementContext _context;

        public EditModel(EventManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EventManagement.Models.Event Event { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            // Rename variable to avoid conflict
            var eventItem = await _context.Events.FirstOrDefaultAsync(m => m.Id == id);
            if (eventItem == null)
                return NotFound();

            Event = eventItem;

            ViewData["OrganizerId"] = new SelectList(_context.Organizers, "Id", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Attach(Event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(Event.Id))
                    return NotFound();
                else
                    throw;
            }

            return RedirectToPage("./Index");
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}
