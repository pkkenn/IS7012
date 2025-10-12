using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EventManagement.Data;
using EventManagement.Models;
using Microsoft.AspNetCore.Authorization;

namespace EventManagement.Pages.Organizer
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly EventManagement.Data.EventManagementContext _context;

        public CreateModel(EventManagement.Data.EventManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EventManagement.Models.Organizer Organizer { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Organizers.Add(Organizer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
