using HomeBudgetDemo.Areas.Identity.Pages.Account;
using HomeBudgetDemo.Models;
using HomeBudgetDemo.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base (options)
        {
            Database.EnsureCreated();
        }

        public DbSet<CostOrIncome> costOrIncomes { get; set; }
        public DbSet<CategoryCost> categoryCosts { get; set; }
        public DbSet<CategoryIncome> categoryIncomes { get; set; }
        public DbSet<RegViewModel> regViewModels { get; set; }
        public DbSet<ViewUser> viewUsers { get; set; }
        
        
    }
}
