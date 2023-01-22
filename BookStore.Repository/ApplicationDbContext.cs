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
        builder.Entity<BookInShoppingCart>()
            .HasKey(z => new { z.BookId, z.ShoppingCartId });

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

        // seed books
        var books = new List<Book>
        {
            new Book
            {
                Id = Guid.NewGuid(),
                BookName = "The Lord of the Rings",
                BookDescription = "The Lord of the Rings is an epic high fantasy novel written by English author and scholar J. R. R. Tolkien. The story began as a sequel to Tolkien's 1937 fantasy novel The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling novels ever written, with over 150 million copies sold.",
                Price = 20,
                BookImage = "https://picsum.photos/200/300",
                Genre = "Fantasy",
            },
            new Book
            {
                Id = Guid.NewGuid(),
                BookName = "Harry Potter and the Philosopher's Stone",
                BookDescription = "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school, and with the help of his friends, Harry faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.",
                Price = 15,
                BookImage = "https://upload.wikimedia.org/wikipedia/en/6/6b/Harry_Potter_and_the_Philosopher%27s_Stone_Book_Cover.jpg",
                Genre = "Fantasy",
            },
            new Book
            {
                Id = Guid.NewGuid(),
                BookName = "The Hobbit",
                BookDescription = "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published on 21 September 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction. The book remains popular and is recognized as a classic in children's literature.",
                Price = 10,
                BookImage = "https://m.media-amazon.com/images/I/51B9ZIPwB9L._AC_SY780_.jpg",
                Genre = "Fantasy",
            },
            new Book
            {
                Id = Guid.NewGuid(),
                BookName = "The Little Prince",
                BookDescription = "The Little Prince is a novella, the most famous work of French aristocrat, writer, poet, and pioneering aviator Antoine de Saint-Exupéry.",
                Price = 5,
                BookImage = "https://m.media-amazon.com/images/I/41PoMV3g31L._SX323_BO1,204,203,200_.jpg",
                Genre = "Fantasy"
            },
            new Book
            {
                Id = Guid.NewGuid(),
                BookName = "The Hitchhiker's Guide to the Galaxy",
                BookDescription = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction series created by Douglas Adams. Originally a radio comedy broadcast on BBC Radio 4 in 1978, it was later adapted to other formats, and over several years it gradually became an international multi-media phenomenon.",
                Price = 10,
                BookImage = "https://i.guim.co.uk/img/static/sys-images/Guardian/Pix/pictures/2015/6/25/1435245979235/047c9878-9845-473c-9635-5f32545746b0-1355x2040.jpeg?width=700&quality=85&auto=format&fit=max&s=606433bda33c8c27c5ebd7ba85900473",
                Genre = "Comedy",
            },
            new Book
            {
                Id = Guid.NewGuid(),
                BookName = "The Restaurant at the End of the Universe",
                BookDescription = "The Restaurant at the End of the Universe is a science fiction comedy novel by Douglas Adams, the second in the Hitchhiker's Guide to the Galaxy series. It was first published in the United Kingdom on 1 October 1980 by Pan Books, and in the United States on 1 November 1980 by Del Rey Books.",
                Price = 10,
                BookImage = "https://uploads-ssl.webflow.com/5f29b3f3cea3ad5a1b369735/5fb1a6558e1c0c4e2c8c2c80_the-restaurant-at-the-end-of-the-universe.png",
                Genre = "Comedy",
            },
            new Book
            {
                Id = Guid.NewGuid(),
                BookName = "Life, the Universe and Everything",
                BookDescription = "Life, the Universe and Everything is a science fiction comedy novel by Douglas Adams, the third in the Hitchhiker's Guide to the Galaxy series. It was first published in the United Kingdom on 27 October 1982 by Pan Books, and in the United States on 1 November 1982 by Del Rey Books.",
                Price = 10,
                BookImage = "https://m.media-amazon.com/images/I/81wGDmo3osL.jpg",
                Genre = "Comedy",
            },
            new Book
            {
                Id = Guid.NewGuid(),
                BookName = "Dracula",
                BookDescription = "Dracula is an 1897 Gothic horror novel by Irish author Bram Stoker. Famous for introducing the character of the vampire Count Dracula, the novel tells the story of Dracula's attempt to move from Transylvania to England so that he may find new blood and spread the undead curse, and of the battle between Dracula and a small volverine",
                Price = 10,
                BookImage = "https://picsum.photos/200/300",
                Genre = "Horror",
            },
            new Book
            {
                Id = Guid.NewGuid(),
                BookName = "Frankenstein",
                BookDescription = "Frankenstein; or, The Modern Prometheus is a novel written by English author Mary Shelley that tells the story of Victor Frankenstein, a young scientist who creates a hideous sapient creature in an unorthodox scientific experiment. Shelley started writing the story when she was 18, and the novel was published when she was 20.",
                Price = 10,
                BookImage = "https://m.media-amazon.com/images/I/81z7E0uWdtL.jpg",
                Genre = "Horror",
            },
            new Book
            {
                Id = Guid.NewGuid(),
                BookName = "The Picture of Dorian Gray",
                BookDescription = "The Picture of Dorian Gray is a philosophical novel by Oscar Wilde, first published complete in the July 1890 issue of Lippincott's Monthly Magazine. Fearing the story was indecent, the magazine's editor deleted roughly five hundred words before publication. The work's initial reception was mixed, with some reviewers praising its literary merits and others condemning the story's immoral content.",
                Price = 10,
                BookImage = "https://cdn2.penguin.com.au/covers/original/9781613774007.jpg",
                Genre = "Horror",
            }
        };
        builder.Entity<Book>().HasData(books);
    }
}
