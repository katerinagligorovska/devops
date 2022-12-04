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

        builder.Entity<Book>()
            .Property(z => z.Id)
            .ValueGeneratedOnAdd();

        builder.Entity<EmailMessage>()
            .Property(z => z.Id)
            .ValueGeneratedOnAdd();

        builder.Entity<Order>()
            .Property(z => z.Id)
            .ValueGeneratedOnAdd();

        builder.Entity<ShoppingCart>()
            .Property(z => z.Id)
            .ValueGeneratedOnAdd();

        builder.Entity<BookInOrder>()
            .Property(z => z.Id)
            .ValueGeneratedOnAdd();

        builder.Entity<BookInShoppingCart>()
            .Property(z => z.Id)
            .ValueGeneratedOnAdd();

        ////deka se relacii
        //builder.Entity<BookInShoppingCart>()
        //    .HasOne(z => z.CurrnetBook)
        //    .WithMany(z => z.BookInShoppingCarts)
        //    .HasForeignKey(z => z.ShoppingCartId);

        //builder.Entity<BookInShoppingCart>()
        //    .HasOne(z => z.UserCart)
        //    .WithMany(z => z.Books)
        //    .HasForeignKey(z => z.BookId);

        //za 1-1 
        builder.Entity<ShoppingCart>()
            .HasOne(z => z.Owner)
            .WithOne(z => z.Cart)
            .HasForeignKey<ShoppingCart>(z => z.OwnerId);


        var adminRole = new IdentityRole
        {
            Name = "Admin",
            NormalizedName = "ADMIN"
        };

        var userRole = new IdentityRole
        {
            Name = "User",
            NormalizedName = "USER"
        };

        // add roles
        builder.Entity<IdentityRole>().HasData(adminRole, userRole);

        var adminUser = new EShopAppUser
        {
            FirstName = "Admin",
            LastName = "Admin",
            Email = "admin@test.com",
            NormalizedEmail = "ADMIN@TEST.COM",
            EmailConfirmed = true,
            UserName = "admin@test.com",
            NormalizedUserName = "ADMIN@TEST.COM",
            PhoneNumberConfirmed = true,
        };

        PasswordHasher<EShopAppUser> ph = new PasswordHasher<EShopAppUser>();
        adminUser.PasswordHash = ph.HashPassword(adminUser, "Pass123!");

        // seed user
        builder.Entity<EShopAppUser>().HasData(adminUser);

        // set user role to admin
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = adminRole.Id,
            UserId = adminUser.Id
        });

        var adminCart = new ShoppingCart
        {
            Id = Guid.NewGuid(),
            OwnerId = adminUser.Id
        };
        builder.Entity<ShoppingCart>().HasData(adminCart);
    }

}
