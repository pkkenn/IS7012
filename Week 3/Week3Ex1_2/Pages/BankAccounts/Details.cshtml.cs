using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Week3Ex1.Models;
using Week3Ex1_2.Data;

namespace Week3Ex1.Pages.BankAccounts
{
    public class DetailsModel : PageModel
    {
        private readonly Week3Ex1_2.Data.Week3Ex1_2Context _context;

        public DetailsModel(Week3Ex1_2.Data.Week3Ex1_2Context context)
        {
            _context = context;
        }

        public BankAccount BankAccount { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankaccount = await _context.BankAccount.FirstOrDefaultAsync(m => m.ID == id);

            if (bankaccount is not null)
            {
                BankAccount = bankaccount;

                return Page();
            }

            return NotFound();
        }
    }
}
