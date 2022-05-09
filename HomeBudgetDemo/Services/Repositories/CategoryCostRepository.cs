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
    public class CategoryCostRepository : ICategoryCostInterface
    {
        private readonly AppDbContext _dbContext;

       
        public CategoryCostRepository(AppDbContext dbContext)

        {
            _dbContext = dbContext;    
        }
        public Task<CategoryCost> AddCategoryCost(CategoryCost category)
        {
            _dbContext.categoryCosts.Add(category);
            _dbContext.SaveChanges();

            return Task.FromResult(category);
        }

        public Task DeleteCategoryCost(int id)
        {
            _dbContext.categoryCosts.Remove(_dbContext.categoryCosts.FirstOrDefault(p => p.Id == id));
            _dbContext.SaveChanges();

            return Task.FromResult( id);
        }

        public Task<CategoryCost> GetCategoryCost(int id)
        {
            var category = _dbContext.categoryCosts.FirstOrDefault(p => p.Id == id);
            
            return Task.FromResult(category);
        }


        public Task<List<CategoryCost>> GetCategoryCosts()
        {
            
            return _dbContext.categoryCosts.ToListAsync();
        }

        public Task<CategoryCost> UpdateCategoryCost(CategoryCost category)
        {
            _dbContext.categoryCosts.Update(category);
            _dbContext.SaveChanges();
            return Task.FromResult(category);
        }
    }
}
