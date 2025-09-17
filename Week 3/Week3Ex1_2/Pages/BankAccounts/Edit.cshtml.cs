using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Week3Ex1_2.Data;
using Week3Ex1_2.Models;

namespace Week3Ex1.Pages.BankAccounts
{
    public class EditModel : PageModel
    {
        private readonly Week3Ex1_2.Data.Week3Ex1_2Context _context;

        public EditModel(Week3Ex1_2.Data.Week3Ex1_2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public BankAccount BankAccount { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankaccount =  await _context.BankAccount.FirstOrDefaultAsync(m => m.ID == id);
            if (bankaccount == null)
            {
                return NotFound();
            }
            BankAccount = bankaccount;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BankAccount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankAccountExists(BankAccount.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BankAccountExists(int id)
        {
            return _context.BankAccount.Any(e => e.ID == id);
        }
    }
}
