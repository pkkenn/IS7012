using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatAlexiskh.Data;
using RecruitCatAlexiskh.Models;

namespace RecruitCatAlexiskh.Pages.JobTitles
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatAlexiskh.Data.RecruitCatAlexiskhContext _context;

        public DetailsModel(RecruitCatAlexiskh.Data.RecruitCatAlexiskhContext context)
        {
            _context = context;
        }

        public JobTitle JobTitle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.ID == id);

            if (jobtitle is not null)
            {
                JobTitle = jobtitle;

                return Page();
            }

            return NotFound();
        }
    }
}
