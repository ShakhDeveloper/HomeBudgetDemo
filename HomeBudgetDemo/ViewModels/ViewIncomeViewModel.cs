using HomeBudgetDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.ViewModels
{
    public class ViewIncomeViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public CostOrIncomeType type { get; set; }
        public double Sum { get; set; }
        public string Comment { get; set; }
        public string CategoryName { get; set; }
    }
}
