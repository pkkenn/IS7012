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

namespace EventManagement.Pages.Events
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly EventManagementContext _context;

        public CreateModel(EventManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Event Event { get; set; } = default!;

        public IActionResult OnGet()
        {
            ViewData["OrganizerId"] = new SelectList(_context.Organizers, "Id", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // ✅ Debug output to identify why creation fails
            Console.WriteLine($"ModelState.IsValid = {ModelState.IsValid}");
            foreach (var entry in ModelState)
            {
                if (entry.Value?.Errors.Count > 0)
                {
                    Console.WriteLine($"❌ {entry.Key}: {entry.Value.Errors[0].ErrorMessage}");
                }
            }

            if (!ModelState.IsValid)
            {
                ViewData["OrganizerId"] = new SelectList(_context.Organizers, "Id", "Name");
                return Page();
            }

            _context.Events.Add(Event);
            await _context.SaveChangesAsync();

            Console.WriteLine("✅ Event saved successfully!");
            return RedirectToPage("./Index");
        }
    }
}

