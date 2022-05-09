using HomeBudgetDemo.Data;
using HomeBudgetDemo.Models;
using HomeBudgetDemo.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Services.Repositories
{
    public class CategoryIncomeRepository : ICategoryIncomeInterface
    {
        private readonly AppDbContext _dbContext;

        public CategoryIncomeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<CategoryIncome> AddCategoryIncome(CategoryIncome category)
        {
            _dbContext.categoryIncomes.Add(category);
            _dbContext.SaveChanges();
           
            return Task.FromResult(category);
        }

        public Task DeleteCategoryIncome(int id)
        {
            _dbContext.categoryIncomes.Remove(_dbContext.categoryIncomes.FirstOrDefault(p => p.Id == id));
            _dbContext.SaveChanges();

            return Task.FromResult(id);
        }

        public Task<CategoryIncome> GetCategoryIncome(int id)
        {
            var category = _dbContext.categoryIncomes.FirstOrDefault(p => p.Id == id);

            return Task.FromResult(category);
        }

        public Task<List<CategoryIncome>> GetCategoryIncomes()
        {
            return _dbContext.categoryIncomes.ToListAsync();
        }

        public Task<CategoryIncome> UpdateCategoryIncome(CategoryIncome category)
        {
            _dbContext.categoryIncomes.Update(category);
            _dbContext.SaveChanges();

            return Task.FromResult(category);
        }
    }
}
