using System.ComponentModel.DataAnnotations;

namespace BookStore.Web.ViewModel;

public class AddUserToRolePostViewModel
{
    [Required]
    [Display(Name = "User ID")]
    public string UserId { get; set; } = null!;

    [Required]
    [Display(Name = "Role ID")]
    public string RoleId { get; set; } = null!;
}

public class AddUserToRoleViewModel : AddUserToRolePostViewModel
{
    [Required]
    public UserViewModel User { get; set; }

    [Required]
    [Display(Name = "Available Roles")]
    public List<RoleViewModel> Roles { get; set; }

    public AddUserToRoleViewModel(UserViewModel user, List<RoleViewModel> roles)
    {
        UserId = user.Id;
        User = user;
        Roles = roles;
    }

}
