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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryCost>().HasData(
                         new CategoryCost()
                    {
                        Id =1,
                        Name = "Продукты питания"
                    },
                         new CategoryCost()
                      {
                          Id = 2,
                          Name = "Домашнее хозяйство"
                      },
                         new CategoryCost()
                       {
                           Id = 3,
                           Name = "Досуг и отдых"
                       },
                         new CategoryCost()
                        {
                            Id = 4,
                            Name = "Коммунальные платежи"
                        },
                         new CategoryCost()
                         {
                             Id = 5,
                             Name = "Медицина"
                         },
                         new CategoryCost()
                         {
                             Id = 6,
                             Name = "Одежда, обувь, аксессуары"
                         },
                         new CategoryCost()
                         {
                             Id = 7,
                             Name = "Проезд, транспорт"
                         },
                         new CategoryCost()
                         {
                             Id = 8,
                             Name = "Связь, ТВ и интернет"
                         },
                         new CategoryCost()
                         {
                             Id = 9,
                             Name = "Уход за собой"
                         },
                         new CategoryCost()
                         {
                             Id = 10,
                             Name = "Автомобиль"
                         }
                );
            modelBuilder.Entity<CategoryIncome>().HasData(
                    new CategoryIncome()
                    {
                        Id = 1,
                        Name = "Заработная плата"
                    },
                    new CategoryIncome()
                    {
                        Id = 2,
                        Name = "Пенсия"
                    },
                    new CategoryIncome()
                    {
                        Id = 3,
                        Name = "Доход от аренды имущества"
                    },
                    new CategoryIncome()
                    {
                        Id = 4,
                        Name = "Прочие доходы"
                    }
                );
        }


    }
}
