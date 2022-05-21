using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetDemo.ViewModels
{
    [Table("RegDB")]
    public class RegViewModel
    {
        [Required, Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = " Имя")]
        public string FirstNme { get; set; }

        [Required]
        [Display(Name = " Фамилия")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают!")]
        [DataType(DataType.Password)]
        [Display(Name = " Потвердить пароль")]
        public string PasswordConfim { get; set; }

        [Display(Name ="Дата входа")]
        public DateTime Time { get; set; }
    }
}
