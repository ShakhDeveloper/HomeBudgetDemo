using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Models
{
    [Table("CategoryIncome")]
    public class CategoryIncome
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
