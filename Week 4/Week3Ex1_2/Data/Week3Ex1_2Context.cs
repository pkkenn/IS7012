using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Week3Ex1_2.Models;

namespace Week3Ex1_2.Data
{
    public class Week3Ex1_2Context : DbContext
    {
        public Week3Ex1_2Context (DbContextOptions<Week3Ex1_2Context> options)
            : base(options)
        {
        }

        public DbSet<Week3Ex1_2.Models.AccountHolder> AccountHolder { get; set; } = default!;
        public DbSet<Week3Ex1_2.Models.BankAccount> BankAccount { get; set; } = default!;
    }
}
