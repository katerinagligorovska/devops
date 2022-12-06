using System.ComponentModel.DataAnnotations;

namespace BookStore.Web.ViewModel;

public class UserViewModel
{
    [Required]
    [Display(Name = "User ID")]
    public string Id { get; set; }

    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [Display(Name = "Email")]
    public string Email { get; set; }

    public UserViewModel(string id, string firstName, string lastName, string email)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}
