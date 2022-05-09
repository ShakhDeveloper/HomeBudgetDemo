using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.Models
{ [Table("CategoryCost")]
    public class CategoryCost
    {
        [Key , Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
