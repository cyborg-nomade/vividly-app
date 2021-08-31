using System.ComponentModel.DataAnnotations;

namespace vividly_app.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}