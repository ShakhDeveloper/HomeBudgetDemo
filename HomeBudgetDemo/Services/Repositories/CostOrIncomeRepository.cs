using HomeBudgetDemo.Data;
using HomeBudgetDemo.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Services.Repositories
{
    public class CostOrIncomeRepository : ICostOrIncomeInterface
    {
        private readonly AppDbContext _dbContext;

        public CostOrIncomeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<CostOrIncome> AddCostOrIncome(CostOrIncome costOrIncome)
        {
            _dbContext.costOrIncomes.Add(costOrIncome);
            _dbContext.SaveChanges();

            return Task.FromResult(costOrIncome);
        }

        public Task DeleteCostOrIncome(int id)
        {
            _dbContext.costOrIncomes.Remove(_dbContext.costOrIncomes.FirstOrDefault(p => p.Id == id));
            _dbContext.SaveChanges();

            return Task.FromResult(id);
        }

        public Task<CostOrIncome> GetCostOrIncome(int id)
        {
            var costOrIncome = _dbContext.costOrIncomes.FirstOrDefault(p => p.Id == id);

            return Task.FromResult(costOrIncome);
        }

        public Task<List<CostOrIncome>> GetCostOrIncomes()
        {
            return _dbContext.costOrIncomes.ToListAsync();
        }

        public Task<CostOrIncome> UpdateCostOrIncome(CostOrIncome costOrIncome)
        {
            _dbContext.costOrIncomes.Update(costOrIncome);
            _dbContext.SaveChanges();

            return Task.FromResult(costOrIncome);
        }
    }
}
