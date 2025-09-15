using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatAlexiskh.Models;

namespace RecruitCatAlexiskh.Data
{
    public class RecruitCatAlexiskhContext : DbContext
    {
        public RecruitCatAlexiskhContext (DbContextOptions<RecruitCatAlexiskhContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatAlexiskh.Models.JobTitle> JobTitle { get; set; } = default!;
        public DbSet<RecruitCatAlexiskh.Models.Candidate> Candidate { get; set; } = default!;
        public DbSet<RecruitCatAlexiskh.Models.Company> Company { get; set; } = default!;
        public DbSet<RecruitCatAlexiskh.Models.Industry> Industry { get; set; } = default!;
    }
}
