using BookStore.Domain.Identity;
using BookStore.Domain.Entity;
using BookStore.Service.Interface;
using BookStore.Web.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookStore.Web.Controllers;
public class AccountController : Controller
{
    private readonly UserManager<EShopAppUser> userManager;
    private readonly SignInManager<EShopAppUser> signInManager;
    private readonly RoleManager<IdentityRole> roleManager;
    private readonly IUserService userService;

    public AccountController(UserManager<EShopAppUser> userManager, SignInManager<EShopAppUser> signInManager, RoleManager<IdentityRole> roleManager, IUserService userService)
    {
        this.userManager = userManager;
        this.signInManager = signInManager;
        this.roleManager = roleManager;
        this.userService = userService;
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Register() => View();

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (!ModelState.IsValid)
        {
            ModelState.AddModelError(string.Empty, "Invalid registration attempt");
            return View(model);
        }

        if (await userManager.FindByEmailAsync(model.Email) != null)
        {
            ModelState.AddModelError("Email", "Email already in use");
            return View(model);
        }

        var user = new EShopAppUser
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            NormalizedEmail = model.Email.ToUpper(),
            UserName = model.Email,
            NormalizedUserName = model.Email.ToUpper(),
            EmailConfirmed = true,
            Cart = new ShoppingCart()
        };
        var result = await userManager.CreateAsync(user, model.Password);
        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }
        await userManager.AddToRoleAsync(user, RoleName.User);
        await signInManager.SignInAsync(user, isPersistent: false);
        return RedirectToAction("Index", "Books");
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Login() => View();

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
        {
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(model);
        }
        var user = await userManager.FindByEmailAsync(model.Email);
        if (user == null)
        {
            ModelState.AddModelError(string.Empty, $"User with email {model.Email} does not exist");
            return View(model);
        }

        var result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, true);
        if (!result.Succeeded)
        {
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(model);
        }

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.FullName),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Role, RoleName.User)
        };
        await userManager.AddClaimsAsync(user, claims);
        return RedirectToAction("Index", "Books");
    }

    public async Task<IActionResult> Logout()
    {
        await signInManager.SignOutAsync();
        return RedirectToAction("Login", "Account");
    }

    [HttpGet]
    [AllowAnonymous]
    public IActionResult UserList()
    {
        string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var users = userService
            .GetAllUsers()
            .Where(user => user.Id != id)
            .ToList()
            .ConvertAll(new Converter<EShopAppUser, UserViewModel>(
                user => new UserViewModel(user.Id, user.FirstName, user.LastName, user.Email)
                )
            );
        return View(users);
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> ManageUserRoles([FromQuery] string id)
    {
        var user = userService.GetUserById(id);
        var userViewModel = new UserViewModel(user.Id, user.FirstName, user.LastName, user.Email);
        var userRoles = await userManager.GetRolesAsync(user);
        var allRoles = roleManager.Roles.ToList();
        var availableRoles = allRoles
            .Where(role => !userRoles.Contains(role.Name))
            .ToList()
            .ConvertAll(
                new Converter<IdentityRole, RoleViewModel>(
                    role => new RoleViewModel(Guid.Parse(role.Id), role.Name)
                )
            );
        var model = new AddUserToRoleViewModel(userViewModel, availableRoles);
        return View(model);
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> ManageUserRoles(AddUserToRolePostViewModel model)
    {
        var user = userService.GetUserById(model.UserId);
        var role = await roleManager.FindByIdAsync(model.RoleId.ToString());
        var result = await userManager.AddToRoleAsync(user, role.Name);
        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }
        return RedirectToAction("ManageUserRoles", "Account");
    }
}
