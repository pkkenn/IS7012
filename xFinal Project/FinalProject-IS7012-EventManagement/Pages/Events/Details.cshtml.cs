using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EventManagement.Data;
using EventManagement.Models;

namespace EventManagement.Pages.Events
{
    public class DetailsModel : PageModel
    {
        private readonly EventManagementContext _context;

        public DetailsModel(EventManagementContext context)
        {
            _context = context;
        }

        public EventManagement.Models.Event Event { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            // Rename variable to avoid conflict
            var eventItem = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);

            if (eventItem == null)
                return NotFound();

            Event = eventItem;
            return Page();
        }
    }
}
