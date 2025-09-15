using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatAlexiskh.Data;
using RecruitCatAlexiskh.Models;

namespace RecruitCatAlexiskh.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatAlexiskh.Data.RecruitCatAlexiskhContext _context;

        public DetailsModel(RecruitCatAlexiskh.Data.RecruitCatAlexiskhContext context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidate = await _context.Candidate.FirstOrDefaultAsync(m => m.ID == id);

            if (candidate is not null)
            {
                Candidate = candidate;

                return Page();
            }

            return NotFound();
        }
    }
}
