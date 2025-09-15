using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatAlexiskh.Data;
using RecruitCatAlexiskh.Models;

namespace RecruitCatAlexiskh.Pages.Industries
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatAlexiskh.Data.RecruitCatAlexiskhContext _context;

        public DeleteModel(RecruitCatAlexiskh.Data.RecruitCatAlexiskhContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Industry Industry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var industry = await _context.Industry.FirstOrDefaultAsync(m => m.ID == id);

            if (industry is not null)
            {
                Industry = industry;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var industry = await _context.Industry.FindAsync(id);
            if (industry != null)
            {
                Industry = industry;
                _context.Industry.Remove(Industry);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
