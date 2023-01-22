using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Repository.Migrations
{
    public partial class ChangeImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1c5bc26-2f19-4d9c-831d-d71dc348878b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a88bf495-0c51-4c55-84d5-d6370f185a96", "530dc134-9409-4c43-b771-37d1808f5aba" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("030ec5a3-e8f7-4558-bef9-b149bf5622b6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("12921473-9550-415f-b9e5-7634741a7788"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("45acefbf-1fcc-4be9-bca0-3bfb00a8f061"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4edf474b-3c9c-44d9-8648-ee834388ebb3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("88c63aac-5428-4bcd-9967-f09c0d854e39"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9d169535-2f1c-48de-be2d-d3bf50b24bc7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ace12fa8-93e1-4133-891e-751739b07874"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("adbd9abe-54fc-43cd-8cdc-64b153119f8d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b5049da6-ab71-4599-b7fa-6f43301dbad0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c88730e0-365e-4fd4-b472-eea69292d3a3"));

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: new Guid("10d29e1b-1168-4b46-ae7e-7468eb1156a5"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a88bf495-0c51-4c55-84d5-d6370f185a96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "530dc134-9409-4c43-b771-37d1808f5aba");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "a88bf495-0c51-4c55-84d5-d6370f185a96", "17979143-00ba-4a04-aae0-56a870cf5057", "Admin", "ADMIN" },
                    { "c1c5bc26-2f19-4d9c-831d-d71dc348878b", "94f1af5e-d4ad-437e-ad77-1c21625df696", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "530dc134-9409-4c43-b771-37d1808f5aba", 0, "6620af8b-9bff-48fa-87a6-c3850155421c", "admin@test.com", true, "Admin", "Admin", false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEAhiXeC2iRjiBZYw+AkexhciPU74iil/0QmNPkP51W0rwtbp18ouy98LotLFtqfW/g==", null, false, "20d6c1a0-8c1d-4da7-81fa-9020f2b7c1ce", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookDescription", "BookImage", "BookName", "Genre", "Price" },
                values: new object[,]
                {
                    { new Guid("030ec5a3-e8f7-4558-bef9-b149bf5622b6"), "The Picture of Dorian Gray is a philosophical novel by Oscar Wilde, first published complete in the July 1890 issue of Lippincott's Monthly Magazine. Fearing the story was indecent, the magazine's editor deleted roughly five hundred words before publication. The work's initial reception was mixed, with some reviewers praising its literary merits and others condemning the story's immoral content.", "https://picsum.photos/200/300", "The Picture of Dorian Gray", "Horror", 10 },
                    { new Guid("12921473-9550-415f-b9e5-7634741a7788"), "Dracula is an 1897 Gothic horror novel by Irish author Bram Stoker. Famous for introducing the character of the vampire Count Dracula, the novel tells the story of Dracula's attempt to move from Transylvania to England so that he may find new blood and spread the undead curse, and of the battle between Dracula and a small volverine", "https://picsum.photos/200/300", "Dracula", "Horror", 10 },
                    { new Guid("45acefbf-1fcc-4be9-bca0-3bfb00a8f061"), "The Lord of the Rings is an epic high fantasy novel written by English author and scholar J. R. R. Tolkien. The story began as a sequel to Tolkien's 1937 fantasy novel The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling novels ever written, with over 150 million copies sold.", "https://picsum.photos/200/300", "The Lord of the Rings", "Fantasy", 20 },
                    { new Guid("4edf474b-3c9c-44d9-8648-ee834388ebb3"), "Frankenstein; or, The Modern Prometheus is a novel written by English author Mary Shelley that tells the story of Victor Frankenstein, a young scientist who creates a hideous sapient creature in an unorthodox scientific experiment. Shelley started writing the story when she was 18, and the novel was published when she was 20.", "https://picsum.photos/200/300", "Frankenstein", "Horror", 10 },
                    { new Guid("88c63aac-5428-4bcd-9967-f09c0d854e39"), "Life, the Universe and Everything is a science fiction comedy novel by Douglas Adams, the third in the Hitchhiker's Guide to the Galaxy series. It was first published in the United Kingdom on 27 October 1982 by Pan Books, and in the United States on 1 November 1982 by Del Rey Books.", "https://picsum.photos/200/300", "Life, the Universe and Everything", "Comedy", 10 },
                    { new Guid("9d169535-2f1c-48de-be2d-d3bf50b24bc7"), "The Hitchhiker's Guide to the Galaxy is a comedy science fiction series created by Douglas Adams. Originally a radio comedy broadcast on BBC Radio 4 in 1978, it was later adapted to other formats, and over several years it gradually became an international multi-media phenomenon.", "https://picsum.photos/200/300", "The Hitchhiker's Guide to the Galaxy", "Comedy", 10 },
                    { new Guid("ace12fa8-93e1-4133-891e-751739b07874"), "The Restaurant at the End of the Universe is a science fiction comedy novel by Douglas Adams, the second in the Hitchhiker's Guide to the Galaxy series. It was first published in the United Kingdom on 1 October 1980 by Pan Books, and in the United States on 1 November 1980 by Del Rey Books.", "https://picsum.photos/200/300", "The Restaurant at the End of the Universe", "Comedy", 10 },
                    { new Guid("adbd9abe-54fc-43cd-8cdc-64b153119f8d"), "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published on 21 September 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction. The book remains popular and is recognized as a classic in children's literature.", "https://picsum.photos/200/300", "The Hobbit", "Fantasy", 10 },
                    { new Guid("b5049da6-ab71-4599-b7fa-6f43301dbad0"), "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school, and with the help of his friends, Harry faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.", "https://picsum.photos/200/300", "Harry Potter and the Philosopher's Stone", "Fantasy", 15 },
                    { new Guid("c88730e0-365e-4fd4-b472-eea69292d3a3"), "The Little Prince is a novella, the most famous work of French aristocrat, writer, poet, and pioneering aviator Antoine de Saint-Exupéry.", "https://picsum.photos/200/300", "The Little Prince", "Fantasy", 5 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a88bf495-0c51-4c55-84d5-d6370f185a96", "530dc134-9409-4c43-b771-37d1808f5aba" });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "OwnerId" },
                values: new object[] { new Guid("10d29e1b-1168-4b46-ae7e-7468eb1156a5"), "530dc134-9409-4c43-b771-37d1808f5aba" });
        }
    }
}
