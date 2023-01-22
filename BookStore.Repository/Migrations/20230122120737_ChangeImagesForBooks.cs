using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Repository.Migrations
{
    public partial class ChangeImagesForBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8731268b-3e62-4ef3-845a-4e83fbd28c7c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "03ce9324-ba34-4e4d-a2ab-fca2c724d0c5", "87c0243a-0c36-4e3a-8554-2b7166a237dd" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0b5a995b-af98-43ae-b1d8-0a7996da5b28"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("13e02226-260a-487c-9bc6-bd7e18ae1ee5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("17fa871a-44f4-45c2-b469-da73b9e72a88"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("243f8bb9-639d-458e-bc2d-d2716dee5668"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("482ca556-b91b-468a-8762-63d4788c4100"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("646b5882-ed8e-4a78-8bac-21179e12549e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a144c54e-d96a-4a73-b88f-84baf552864d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b999d596-4a6c-409d-8780-5e3e604b4169"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cd186b37-9990-43d6-a9f8-07dce9109ed4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fed96265-855a-48e6-99b9-7a45bcdb79e0"));

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: new Guid("7fbce2b8-55f3-4079-a24b-13ce90f0a5a4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03ce9324-ba34-4e4d-a2ab-fca2c724d0c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87c0243a-0c36-4e3a-8554-2b7166a237dd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04b85d7f-b5c5-4af6-900b-0e914310c477", "daa1e234-0a35-486d-828f-8fe067e93513", "Admin", "ADMIN" },
                    { "fb6b3f0b-bccf-4d8e-96c7-06927b716f12", "fac3b8da-4589-4d4e-a69d-e6657b1cc7a5", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8027c7d0-2ed8-4238-9899-e159b27087e8", 0, "c91c066e-ef58-4b12-b1c0-17e18fb572e6", "admin@test.com", true, "Admin", "Admin", false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEFCYt9mlpd9PBAWynGT+XB5Mj1F2OM9xttr6ffTEk4yTUTsn1B/M7kYmbiW8gvFWnA==", null, false, "199956d1-b618-49be-864b-de292ebe802c", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookDescription", "BookImage", "BookName", "Genre", "Price" },
                values: new object[,]
                {
                    { new Guid("007e2396-8984-4e42-9363-a8a1df5a8039"), "The Picture of Dorian Gray is a philosophical novel by Oscar Wilde, first published complete in the July 1890 issue of Lippincott's Monthly Magazine. Fearing the story was indecent, the magazine's editor deleted roughly five hundred words before publication. The work's initial reception was mixed, with some reviewers praising its literary merits and others condemning the story's immoral content.", "https://cdn2.penguin.com.au/covers/original/9781613774007.jpg", "The Picture of Dorian Gray", "Horror", 10 },
                    { new Guid("57d9d791-0ceb-4147-9407-a098e3aee2df"), "Dracula is an 1897 Gothic horror novel by Irish author Bram Stoker. Famous for introducing the character of the vampire Count Dracula, the novel tells the story of Dracula's attempt to move from Transylvania to England so that he may find new blood and spread the undead curse, and of the battle between Dracula and a small volverine", "https://picsum.photos/200/300", "Dracula", "Horror", 10 },
                    { new Guid("66343af9-f15f-4e39-a3ef-4e17bb1e4a47"), "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school, and with the help of his friends, Harry faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.", "https://upload.wikimedia.org/wikipedia/en/6/6b/Harry_Potter_and_the_Philosopher%27s_Stone_Book_Cover.jpg", "Harry Potter and the Philosopher's Stone", "Fantasy", 15 },
                    { new Guid("6d9233e1-c7e3-4f4b-baf8-b94e3cec4972"), "The Restaurant at the End of the Universe is a science fiction comedy novel by Douglas Adams, the second in the Hitchhiker's Guide to the Galaxy series. It was first published in the United Kingdom on 1 October 1980 by Pan Books, and in the United States on 1 November 1980 by Del Rey Books.", "https://uploads-ssl.webflow.com/5f29b3f3cea3ad5a1b369735/5fb1a6558e1c0c4e2c8c2c80_the-restaurant-at-the-end-of-the-universe.png", "The Restaurant at the End of the Universe", "Comedy", 10 },
                    { new Guid("724e13b6-d79f-41da-b5c9-30ec93a9810e"), "Frankenstein; or, The Modern Prometheus is a novel written by English author Mary Shelley that tells the story of Victor Frankenstein, a young scientist who creates a hideous sapient creature in an unorthodox scientific experiment. Shelley started writing the story when she was 18, and the novel was published when she was 20.", "https://m.media-amazon.com/images/I/81z7E0uWdtL.jpg", "Frankenstein", "Horror", 10 },
                    { new Guid("83dc2b18-5e6b-4509-b2a9-8b7c3e778a46"), "The Lord of the Rings is an epic high fantasy novel written by English author and scholar J. R. R. Tolkien. The story began as a sequel to Tolkien's 1937 fantasy novel The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling novels ever written, with over 150 million copies sold.", "https://picsum.photos/200/300", "The Lord of the Rings", "Fantasy", 20 },
                    { new Guid("b44d3c1d-2c6e-4357-a8a3-346eface979b"), "The Little Prince is a novella, the most famous work of French aristocrat, writer, poet, and pioneering aviator Antoine de Saint-Exupéry.", "https://m.media-amazon.com/images/I/41PoMV3g31L._SX323_BO1,204,203,200_.jpg", "The Little Prince", "Fantasy", 5 },
                    { new Guid("bb2f1e58-8b3a-4a61-82d9-499715f07c34"), "Life, the Universe and Everything is a science fiction comedy novel by Douglas Adams, the third in the Hitchhiker's Guide to the Galaxy series. It was first published in the United Kingdom on 27 October 1982 by Pan Books, and in the United States on 1 November 1982 by Del Rey Books.", "https://m.media-amazon.com/images/I/81wGDmo3osL.jpg", "Life, the Universe and Everything", "Comedy", 10 },
                    { new Guid("bb9bd742-0a1f-4f1e-aa7a-528422420a2f"), "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published on 21 September 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction. The book remains popular and is recognized as a classic in children's literature.", "https://m.media-amazon.com/images/I/51B9ZIPwB9L._AC_SY780_.jpg", "The Hobbit", "Fantasy", 10 },
                    { new Guid("ecea0be1-da94-4cf0-9eba-eefd524a31ed"), "The Hitchhiker's Guide to the Galaxy is a comedy science fiction series created by Douglas Adams. Originally a radio comedy broadcast on BBC Radio 4 in 1978, it was later adapted to other formats, and over several years it gradually became an international multi-media phenomenon.", "https://i.guim.co.uk/img/static/sys-images/Guardian/Pix/pictures/2015/6/25/1435245979235/047c9878-9845-473c-9635-5f32545746b0-1355x2040.jpeg?width=700&quality=85&auto=format&fit=max&s=606433bda33c8c27c5ebd7ba85900473", "The Hitchhiker's Guide to the Galaxy", "Comedy", 10 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "04b85d7f-b5c5-4af6-900b-0e914310c477", "8027c7d0-2ed8-4238-9899-e159b27087e8" });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "OwnerId" },
                values: new object[] { new Guid("f621fda1-9311-4228-bff9-f4cd980b6add"), "8027c7d0-2ed8-4238-9899-e159b27087e8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb6b3f0b-bccf-4d8e-96c7-06927b716f12");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04b85d7f-b5c5-4af6-900b-0e914310c477", "8027c7d0-2ed8-4238-9899-e159b27087e8" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("007e2396-8984-4e42-9363-a8a1df5a8039"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("57d9d791-0ceb-4147-9407-a098e3aee2df"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("66343af9-f15f-4e39-a3ef-4e17bb1e4a47"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d9233e1-c7e3-4f4b-baf8-b94e3cec4972"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("724e13b6-d79f-41da-b5c9-30ec93a9810e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("83dc2b18-5e6b-4509-b2a9-8b7c3e778a46"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b44d3c1d-2c6e-4357-a8a3-346eface979b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bb2f1e58-8b3a-4a61-82d9-499715f07c34"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bb9bd742-0a1f-4f1e-aa7a-528422420a2f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ecea0be1-da94-4cf0-9eba-eefd524a31ed"));

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: new Guid("f621fda1-9311-4228-bff9-f4cd980b6add"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04b85d7f-b5c5-4af6-900b-0e914310c477");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8027c7d0-2ed8-4238-9899-e159b27087e8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03ce9324-ba34-4e4d-a2ab-fca2c724d0c5", "a848cb03-f8ce-4d66-945e-1524570181f7", "Admin", "ADMIN" },
                    { "8731268b-3e62-4ef3-845a-4e83fbd28c7c", "76ea7ecf-647c-46dd-9dfa-0b71f8e98f16", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "87c0243a-0c36-4e3a-8554-2b7166a237dd", 0, "ccd09f35-ca5a-4ceb-ad32-96fcc4dafecb", "admin@test.com", true, "Admin", "Admin", false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEC8uCzLTzwa98p3U2geCsOM9BbivG66fdiZqqmDWNvoeHZQTz2SSX7JAFnfJVY8Bmg==", null, false, "1ce52055-baea-4069-aa05-41568654f2b2", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookDescription", "BookImage", "BookName", "Genre", "Price" },
                values: new object[,]
                {
                    { new Guid("0b5a995b-af98-43ae-b1d8-0a7996da5b28"), "The Little Prince is a novella, the most famous work of French aristocrat, writer, poet, and pioneering aviator Antoine de Saint-Exupéry.", "https://picsum.photos/200/300", "The Little Prince", "Fantasy", 5 },
                    { new Guid("13e02226-260a-487c-9bc6-bd7e18ae1ee5"), "The Lord of the Rings is an epic high fantasy novel written by English author and scholar J. R. R. Tolkien. The story began as a sequel to Tolkien's 1937 fantasy novel The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling novels ever written, with over 150 million copies sold.", "https://picsum.photos/200/300", "The Lord of the Rings", "Fantasy", 20 },
                    { new Guid("17fa871a-44f4-45c2-b469-da73b9e72a88"), "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school, and with the help of his friends, Harry faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.", "https://picsum.photos/200/300", "Harry Potter and the Philosopher's Stone", "Fantasy", 15 },
                    { new Guid("243f8bb9-639d-458e-bc2d-d2716dee5668"), "The Picture of Dorian Gray is a philosophical novel by Oscar Wilde, first published complete in the July 1890 issue of Lippincott's Monthly Magazine. Fearing the story was indecent, the magazine's editor deleted roughly five hundred words before publication. The work's initial reception was mixed, with some reviewers praising its literary merits and others condemning the story's immoral content.", "https://cdn2.penguin.com.au/covers/original/9781613774007.jpg", "The Picture of Dorian Gray", "Horror", 10 },
                    { new Guid("482ca556-b91b-468a-8762-63d4788c4100"), "The Restaurant at the End of the Universe is a science fiction comedy novel by Douglas Adams, the second in the Hitchhiker's Guide to the Galaxy series. It was first published in the United Kingdom on 1 October 1980 by Pan Books, and in the United States on 1 November 1980 by Del Rey Books.", "https://picsum.photos/200/300", "The Restaurant at the End of the Universe", "Comedy", 10 },
                    { new Guid("646b5882-ed8e-4a78-8bac-21179e12549e"), "The Hitchhiker's Guide to the Galaxy is a comedy science fiction series created by Douglas Adams. Originally a radio comedy broadcast on BBC Radio 4 in 1978, it was later adapted to other formats, and over several years it gradually became an international multi-media phenomenon.", "https://picsum.photos/200/300", "The Hitchhiker's Guide to the Galaxy", "Comedy", 10 },
                    { new Guid("a144c54e-d96a-4a73-b88f-84baf552864d"), "Frankenstein; or, The Modern Prometheus is a novel written by English author Mary Shelley that tells the story of Victor Frankenstein, a young scientist who creates a hideous sapient creature in an unorthodox scientific experiment. Shelley started writing the story when she was 18, and the novel was published when she was 20.", "https://m.media-amazon.com/images/I/81z7E0uWdtL.jpg", "Frankenstein", "Horror", 10 },
                    { new Guid("b999d596-4a6c-409d-8780-5e3e604b4169"), "Life, the Universe and Everything is a science fiction comedy novel by Douglas Adams, the third in the Hitchhiker's Guide to the Galaxy series. It was first published in the United Kingdom on 27 October 1982 by Pan Books, and in the United States on 1 November 1982 by Del Rey Books.", "https://m.media-amazon.com/images/I/81wGDmo3osL.jpg", "Life, the Universe and Everything", "Comedy", 10 },
                    { new Guid("cd186b37-9990-43d6-a9f8-07dce9109ed4"), "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published on 21 September 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction. The book remains popular and is recognized as a classic in children's literature.", "https://picsum.photos/200/300", "The Hobbit", "Fantasy", 10 },
                    { new Guid("fed96265-855a-48e6-99b9-7a45bcdb79e0"), "Dracula is an 1897 Gothic horror novel by Irish author Bram Stoker. Famous for introducing the character of the vampire Count Dracula, the novel tells the story of Dracula's attempt to move from Transylvania to England so that he may find new blood and spread the undead curse, and of the battle between Dracula and a small volverine", "https://picsum.photos/200/300", "Dracula", "Horror", 10 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "03ce9324-ba34-4e4d-a2ab-fca2c724d0c5", "87c0243a-0c36-4e3a-8554-2b7166a237dd" });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "OwnerId" },
                values: new object[] { new Guid("7fbce2b8-55f3-4079-a24b-13ce90f0a5a4"), "87c0243a-0c36-4e3a-8554-2b7166a237dd" });
        }
    }
}
