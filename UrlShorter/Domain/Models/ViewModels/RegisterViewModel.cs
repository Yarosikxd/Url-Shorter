using System.ComponentModel.DataAnnotations;


namespace Domain.Models.ViewModels
{
    public class RegisterViewModel
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле електронної пошти обов'язкове для заповнення")]
        [EmailAddress(ErrorMessage = "Некоректний формат електронної пошти")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле паролю обов'язкове для заповнення")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "Пароль повинен містити мінімум {2} символів.", MinimumLength = 6)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль та підтвердження пароля не співпадають.")]
        public string ConfirmPassword { get; set; }
    }
}
