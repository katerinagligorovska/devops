using System.ComponentModel.DataAnnotations;

namespace BookStore.Web.ViewModel;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(100)]
    [Display(Name = "First name")]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "Last name is required")]
    [StringLength(100)]
    [Display(Name = "Last name")]
    public string LastName { get; set; } = null!;

    [Required]
    [EmailAddress]
    [Display(Name = "Email address")]
    public string Email { get; set; } = null!;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; } = null!;
}
