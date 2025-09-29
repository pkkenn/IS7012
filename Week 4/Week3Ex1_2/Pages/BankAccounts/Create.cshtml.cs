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
    public class CreateModel : PageModel
    {
        private readonly Week3Ex1_2.Data.Week3Ex1_2Context _context;

        public CreateModel(Week3Ex1_2.Data.Week3Ex1_2Context context)
        {
            _context = context;
        }

        public SelectList AccountHolderList { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            var accountHolders = await _context.AccountHolder.ToListAsync();
            
            AccountHolderList = new SelectList(accountHolders, "ID", "FullName");
            
            return Page();
        }

        [BindProperty]
        public BankAccount BankAccount { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                var accountHolders = await _context.AccountHolder.ToListAsync();
                AccountHolderList = new SelectList(accountHolders, "ID", "FullName");
                return Page();
            }

            _context.BankAccount.Add(BankAccount);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}