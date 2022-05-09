using HomeBudgetDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Services.Interfaces
{
    public interface ICategoryCostInterface
    {
        Task<List<CategoryCost>> GetCategoryCosts();
        Task<CategoryCost> GetCategoryCost(int id);
        Task<CategoryCost> AddCategoryCost(CategoryCost category);
        Task<CategoryCost> UpdateCategoryCost(CategoryCost category);
        Task DeleteCategoryCost(int id);
    }
}
