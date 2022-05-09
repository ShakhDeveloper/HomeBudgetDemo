using HomeBudgetDemo.Models;
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

        }

        public DbSet<CostOrIncome> costOrIncomes { get; set; }
        public DbSet<CategoryCost> categoryCosts { get; set; }
        public DbSet<CategoryIncome> categoryIncomes { get; set; }
    }
}
