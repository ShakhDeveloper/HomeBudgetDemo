using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.ViewModels
{
    [Table("LogUserDb")]
    public class ViewUser
    {
        [Required, Key]

        public Guid Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]

        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}
