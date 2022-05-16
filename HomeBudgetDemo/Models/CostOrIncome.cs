using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Data
{
    [Table("CostOrIncome")]
    public class CostOrIncome
    {
        [Key,Required]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public  CostOrIncomeType type { get; set; }
        [Required]
        public double Sum { get; set; }
        public string Comment { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
    public  enum CostOrIncomeType
    {
        Доход,
        Расход
    }
}
