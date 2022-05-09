using HomeBudgetDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Services.Interfaces
{
   public interface ICostOrIncomeInterface
    {
        Task<List<CostOrIncome>> GetCostOrIncomes();
        Task<CostOrIncome> GetCostOrIncome(int id);
        Task<CostOrIncome> AddCostOrIncome(CostOrIncome costOrIncome);
        Task<CostOrIncome> UpdateCostOrIncome(CostOrIncome costOrIncome);
        Task DeleteCostOrIncome(int id);
    }
}
