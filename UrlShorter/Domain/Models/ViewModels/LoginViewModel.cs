using System.ComponentModel.DataAnnotations;

namespace Domain.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Поле електронної пошти обов'язкове для заповнення")]
        [EmailAddress(ErrorMessage = "Некоректний формат електронної пошти")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле паролю обов'язкове для заповнення")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Запам'ятати мене")]
        public bool RememberMe { get; set; }
    }
}
