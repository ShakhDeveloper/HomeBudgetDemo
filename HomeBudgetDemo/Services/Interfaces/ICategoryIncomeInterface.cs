using HomeBudgetDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Services.Interfaces
{
   public interface ICategoryIncomeInterface
    {
        Task<List<CategoryIncome>> GetCategoryIncomes();
        Task<CategoryIncome> GetCategoryIncome(int id);
        Task<CategoryIncome> AddCategoryIncome(CategoryIncome category);
        Task<CategoryIncome> UpdateCategoryIncome(CategoryIncome category);
        Task DeleteCategoryIncome(int id);
    }
}
