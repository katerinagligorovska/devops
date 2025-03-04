﻿// <auto-generated />
using System;
using BookStore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BookStore.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221212235247_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BookStore.Domain.Entity.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BookDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BookImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("45acefbf-1fcc-4be9-bca0-3bfb00a8f061"),
                            BookDescription = "The Lord of the Rings is an epic high fantasy novel written by English author and scholar J. R. R. Tolkien. The story began as a sequel to Tolkien's 1937 fantasy novel The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling novels ever written, with over 150 million copies sold.",
                            BookImage = "https://picsum.photos/200/300",
                            BookName = "The Lord of the Rings",
                            Genre = "Fantasy",
                            Price = 20
                        },
                        new
                        {
                            Id = new Guid("b5049da6-ab71-4599-b7fa-6f43301dbad0"),
                            BookDescription = "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school, and with the help of his friends, Harry faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.",
                            BookImage = "https://picsum.photos/200/300",
                            BookName = "Harry Potter and the Philosopher's Stone",
                            Genre = "Fantasy",
                            Price = 15
                        },
                        new
                        {
                            Id = new Guid("adbd9abe-54fc-43cd-8cdc-64b153119f8d"),
                            BookDescription = "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published on 21 September 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction. The book remains popular and is recognized as a classic in children's literature.",
                            BookImage = "https://picsum.photos/200/300",
                            BookName = "The Hobbit",
                            Genre = "Fantasy",
                            Price = 10
                        },
                        new
                        {
                            Id = new Guid("c88730e0-365e-4fd4-b472-eea69292d3a3"),
                            BookDescription = "The Little Prince is a novella, the most famous work of French aristocrat, writer, poet, and pioneering aviator Antoine de Saint-Exupéry.",
                            BookImage = "https://picsum.photos/200/300",
                            BookName = "The Little Prince",
                            Genre = "Fantasy",
                            Price = 5
                        },
                        new
                        {
                            Id = new Guid("9d169535-2f1c-48de-be2d-d3bf50b24bc7"),
                            BookDescription = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction series created by Douglas Adams. Originally a radio comedy broadcast on BBC Radio 4 in 1978, it was later adapted to other formats, and over several years it gradually became an international multi-media phenomenon.",
                            BookImage = "https://picsum.photos/200/300",
                            BookName = "The Hitchhiker's Guide to the Galaxy",
                            Genre = "Comedy",
                            Price = 10
                        },
                        new
                        {
                            Id = new Guid("ace12fa8-93e1-4133-891e-751739b07874"),
                            BookDescription = "The Restaurant at the End of the Universe is a science fiction comedy novel by Douglas Adams, the second in the Hitchhiker's Guide to the Galaxy series. It was first published in the United Kingdom on 1 October 1980 by Pan Books, and in the United States on 1 November 1980 by Del Rey Books.",
                            BookImage = "https://picsum.photos/200/300",
                            BookName = "The Restaurant at the End of the Universe",
                            Genre = "Comedy",
                            Price = 10
                        },
                        new
                        {
                            Id = new Guid("88c63aac-5428-4bcd-9967-f09c0d854e39"),
                            BookDescription = "Life, the Universe and Everything is a science fiction comedy novel by Douglas Adams, the third in the Hitchhiker's Guide to the Galaxy series. It was first published in the United Kingdom on 27 October 1982 by Pan Books, and in the United States on 1 November 1982 by Del Rey Books.",
                            BookImage = "https://picsum.photos/200/300",
                            BookName = "Life, the Universe and Everything",
                            Genre = "Comedy",
                            Price = 10
                        },
                        new
                        {
                            Id = new Guid("12921473-9550-415f-b9e5-7634741a7788"),
                            BookDescription = "Dracula is an 1897 Gothic horror novel by Irish author Bram Stoker. Famous for introducing the character of the vampire Count Dracula, the novel tells the story of Dracula's attempt to move from Transylvania to England so that he may find new blood and spread the undead curse, and of the battle between Dracula and a small volverine",
                            BookImage = "https://picsum.photos/200/300",
                            BookName = "Dracula",
                            Genre = "Horror",
                            Price = 10
                        },
                        new
                        {
                            Id = new Guid("4edf474b-3c9c-44d9-8648-ee834388ebb3"),
                            BookDescription = "Frankenstein; or, The Modern Prometheus is a novel written by English author Mary Shelley that tells the story of Victor Frankenstein, a young scientist who creates a hideous sapient creature in an unorthodox scientific experiment. Shelley started writing the story when she was 18, and the novel was published when she was 20.",
                            BookImage = "https://picsum.photos/200/300",
                            BookName = "Frankenstein",
                            Genre = "Horror",
                            Price = 10
                        },
                        new
                        {
                            Id = new Guid("030ec5a3-e8f7-4558-bef9-b149bf5622b6"),
                            BookDescription = "The Picture of Dorian Gray is a philosophical novel by Oscar Wilde, first published complete in the July 1890 issue of Lippincott's Monthly Magazine. Fearing the story was indecent, the magazine's editor deleted roughly five hundred words before publication. The work's initial reception was mixed, with some reviewers praising its literary merits and others condemning the story's immoral content.",
                            BookImage = "https://picsum.photos/200/300",
                            BookName = "The Picture of Dorian Gray",
                            Genre = "Horror",
                            Price = 10
                        });
                });

            modelBuilder.Entity("BookStore.Domain.Entity.EmailMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MailTo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EmailMessages");
                });

            modelBuilder.Entity("BookStore.Domain.Entity.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookStore.Domain.Entity.ShoppingCart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId")
                        .IsUnique();

                    b.ToTable("ShoppingCarts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("10d29e1b-1168-4b46-ae7e-7468eb1156a5"),
                            OwnerId = "530dc134-9409-4c43-b771-37d1808f5aba"
                        });
                });

            modelBuilder.Entity("BookStore.Domain.Identity.EShopAppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "530dc134-9409-4c43-b771-37d1808f5aba",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6620af8b-9bff-48fa-87a6-c3850155421c",
                            Email = "admin@test.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@TEST.COM",
                            NormalizedUserName = "ADMIN@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAhiXeC2iRjiBZYw+AkexhciPU74iil/0QmNPkP51W0rwtbp18ouy98LotLFtqfW/g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "20d6c1a0-8c1d-4da7-81fa-9020f2b7c1ce",
                            TwoFactorEnabled = false,
                            UserName = "admin@test.com"
                        });
                });

            modelBuilder.Entity("BookStore.Domain.Relations.BookInOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("BookInOrder");
                });

            modelBuilder.Entity("BookStore.Domain.Relations.BookInShoppingCart", b =>
                {
                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ShoppingCartId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("BookId", "ShoppingCartId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("BookInShoppingCarts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a88bf495-0c51-4c55-84d5-d6370f185a96",
                            ConcurrencyStamp = "17979143-00ba-4a04-aae0-56a870cf5057",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "c1c5bc26-2f19-4d9c-831d-d71dc348878b",
                            ConcurrencyStamp = "94f1af5e-d4ad-437e-ad77-1c21625df696",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "530dc134-9409-4c43-b771-37d1808f5aba",
                            RoleId = "a88bf495-0c51-4c55-84d5-d6370f185a96"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookStore.Domain.Entity.Order", b =>
                {
                    b.HasOne("BookStore.Domain.Identity.EShopAppUser", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookStore.Domain.Entity.ShoppingCart", b =>
                {
                    b.HasOne("BookStore.Domain.Identity.EShopAppUser", "Owner")
                        .WithOne("Cart")
                        .HasForeignKey("BookStore.Domain.Entity.ShoppingCart", "OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("BookStore.Domain.Relations.BookInOrder", b =>
                {
                    b.HasOne("BookStore.Domain.Entity.Book", "Book")
                        .WithMany("BookInOrders")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Domain.Entity.Order", "Order")
                        .WithMany("BooksInOrder")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BookStore.Domain.Relations.BookInShoppingCart", b =>
                {
                    b.HasOne("BookStore.Domain.Entity.Book", "CurrentBook")
                        .WithMany("BookInShoppingCarts")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Domain.Entity.ShoppingCart", "Cart")
                        .WithMany("BookInShoppingCarts")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("CurrentBook");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BookStore.Domain.Identity.EShopAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookStore.Domain.Identity.EShopAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookStore.Domain.Identity.EShopAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookStore.Domain.Identity.EShopAppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStore.Domain.Entity.Book", b =>
                {
                    b.Navigation("BookInOrders");

                    b.Navigation("BookInShoppingCarts");
                });

            modelBuilder.Entity("BookStore.Domain.Entity.Order", b =>
                {
                    b.Navigation("BooksInOrder");
                });

            modelBuilder.Entity("BookStore.Domain.Entity.ShoppingCart", b =>
                {
                    b.Navigation("BookInShoppingCarts");
                });

            modelBuilder.Entity("BookStore.Domain.Identity.EShopAppUser", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
