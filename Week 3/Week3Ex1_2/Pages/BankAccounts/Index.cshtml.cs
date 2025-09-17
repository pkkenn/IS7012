using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Week3Ex1_2.Data;
using Week3Ex1_2.Models;

namespace Week3Ex1.Pages.BankAccounts
{
    public class IndexModel : PageModel
    {
        private readonly Week3Ex1_2.Data.Week3Ex1_2Context _context;

        public IndexModel(Week3Ex1_2.Data.Week3Ex1_2Context context)
        {
            _context = context;
        }

        public IList<BankAccount> BankAccount { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BankAccount = await _context.BankAccount.ToListAsync();
        }
    }
}
