using HomeBudgetDemo.Data;
using HomeBudgetDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.ViewModels
{
    public class ViewCostModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public CostOrIncomeType type { get; set; }
        public double Sum { get; set; }
        public string Comment { get; set; }
        public int CategoryId { get; set; }
        public CategoryCost CostCateg { get; set; }

        public static explicit operator ViewCostModel(CostOrIncome v)
        {
            return new ViewCostModel
            {
                Id = v.Id,
                Date = v.Date,
                type = v.type,
                Sum = v.Sum,
                Comment = v.Comment,
                CategoryId = v.CategoryId
            };
        }
    }
}
