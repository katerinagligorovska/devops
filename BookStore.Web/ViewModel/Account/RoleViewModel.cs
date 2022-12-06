using System.ComponentModel.DataAnnotations;

namespace BookStore.Web.ViewModel;

public class RoleViewModel
{
    [Required]
    [Display(Name = "Role ID")]
    public Guid Id { get; set; }

    [Required]
    [Display(Name = "Role Name")]
    public string Name { get; set; }

    public RoleViewModel(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}
