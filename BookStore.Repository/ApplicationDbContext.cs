using BookStore.Domain.Entity;
using BookStore.Domain.Identity;
using BookStore.Domain.Relations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository;
public class ApplicationDbContext : IdentityDbContext<EShopAppUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<EmailMessage> EmailMessages { get; set; }
    public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<BookInShoppingCart> BookInShoppingCarts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var adminRole = new IdentityRole
        {
            Id = Guid.NewGuid().ToString(),
            Name = RoleName.Admin,
            NormalizedName = RoleName.Admin.ToUpper(),
        };
        var userRole = new IdentityRole
        {
            Id = Guid.NewGuid().ToString(),
            Name = RoleName.User,
            NormalizedName = RoleName.User.ToUpper(),
        };

        // add roles
        builder.Entity<IdentityRole>().HasData(adminRole);
        builder.Entity<IdentityRole>().HasData(userRole);

        PasswordHasher<EShopAppUser> ph = new PasswordHasher<EShopAppUser>();
        var email = "admin@test.com";
        var username = "admin@test.com";
        var adminUser = new EShopAppUser
        {
            Id = Guid.NewGuid().ToString(),
            FirstName = "Admin",
            LastName = "Admin",
            Email = email,
            NormalizedEmail = email.ToUpper(),
            UserName = username,
            NormalizedUserName = username.ToUpper(),
            EmailConfirmed = true,
        };
        adminUser.PasswordHash = ph.HashPassword(adminUser, "Aa123!");
        builder.Entity<EShopAppUser>().HasData(adminUser);

        var adminUserCart = new ShoppingCart
        {
            Id = Guid.NewGuid(),
            OwnerId = adminUser.Id,
        };
        builder.Entity<ShoppingCart>().HasData(adminUserCart);
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = adminRole.Id,
            UserId = adminUser.Id,
        });
    }

}
