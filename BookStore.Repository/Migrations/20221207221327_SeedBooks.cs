using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Repository.Migrations
{
    public partial class SeedBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3039993d-dd00-41c2-b5e6-f44f40fdca3b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5fc9fc47-01a5-47c9-8509-64f9973e8af6", "edb3b8f2-d34d-4c95-92af-2690f79cd841" });

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: new Guid("248092de-f108-47ad-bced-05fac6eb3a11"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fc9fc47-01a5-47c9-8509-64f9973e8af6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edb3b8f2-d34d-4c95-92af-2690f79cd841");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c9c839f-cc5e-4fc2-a9c6-66cef233e462", "09da2ae8-adbe-4d1f-804b-e7ee9a0f19d6", "Admin", "ADMIN" },
                    { "c0b0b67f-aa4a-4675-9ee3-8fe197f5e2e3", "4ded4bb9-7e1a-4082-9120-eaf6fa553c5f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1d2e2be8-5433-4546-85c4-19ceba8ffa5c", 0, "8f0d798a-a4cc-437e-9a59-367efab64e91", "admin@test.com", true, "Admin", "Admin", false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEPyxjsXFGBiOSqqJif9YBuFNLoRFVpu7eNUhB1ZlpEzwAuW1aterM7dfmudIoK29iw==", null, false, "4258249e-3697-463f-99e2-07ab2825ab54", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookDescription", "BookImage", "BookName", "Genre", "OrderId", "Price", "ShoppingCartId" },
                values: new object[,]
                {
                    { new Guid("0e48b5f3-0a38-4d8a-80eb-c8513941cd70"), "The Restaurant at the End of the Universe is a science fiction comedy novel by Douglas Adams, the second in the Hitchhiker's Guide to the Galaxy series. It was first published in the United Kingdom on 1 October 1980 by Pan Books, and in the United States on 1 November 1980 by Del Rey Books.", "https://picsum.photos/200/300", "The Restaurant at the End of the Universe", "Comedy", null, 10, null },
                    { new Guid("186cc67d-8a63-4b67-a966-72a8bfaa32cb"), "Frankenstein; or, The Modern Prometheus is a novel written by English author Mary Shelley that tells the story of Victor Frankenstein, a young scientist who creates a hideous sapient creature in an unorthodox scientific experiment. Shelley started writing the story when she was 18, and the novel was published when she was 20.", "https://picsum.photos/200/300", "Frankenstein", "Horror", null, 10, null },
                    { new Guid("34fc5a86-719b-4dd5-8665-9602deabf0f6"), "The Hobbit, or There and Back Again is a children's fantasy novel by English author J. R. R. Tolkien. It was published on 21 September 1937 to wide critical acclaim, being nominated for the Carnegie Medal and awarded a prize from the New York Herald Tribune for best juvenile fiction. The book remains popular and is recognized as a classic in children's literature.", "https://picsum.photos/200/300", "The Hobbit", "Fantasy", null, 10, null },
                    { new Guid("55016735-c27b-4fea-970f-00fa92bd09c7"), "The Little Prince is a novella, the most famous work of French aristocrat, writer, poet, and pioneering aviator Antoine de Saint-Exupéry.", "https://picsum.photos/200/300", "The Little Prince", "Fantasy", null, 5, null },
                    { new Guid("60b0b581-55de-46a5-a227-d07f2de86a6c"), "Dracula is an 1897 Gothic horror novel by Irish author Bram Stoker. Famous for introducing the character of the vampire Count Dracula, the novel tells the story of Dracula's attempt to move from Transylvania to England so that he may find new blood and spread the undead curse, and of the battle between Dracula and a small volverine", "https://picsum.photos/200/300", "Dracula", "Horror", null, 10, null },
                    { new Guid("85096c0e-3c09-4fcb-a674-ae09a210570d"), "Life, the Universe and Everything is a science fiction comedy novel by Douglas Adams, the third in the Hitchhiker's Guide to the Galaxy series. It was first published in the United Kingdom on 27 October 1982 by Pan Books, and in the United States on 1 November 1982 by Del Rey Books.", "https://picsum.photos/200/300", "Life, the Universe and Everything", "Comedy", null, 10, null },
                    { new Guid("e00eb059-fb1c-4695-bc61-40cbce4c5a0f"), "The Lord of the Rings is an epic high fantasy novel written by English author and scholar J. R. R. Tolkien. The story began as a sequel to Tolkien's 1937 fantasy novel The Hobbit, but eventually developed into a much larger work. Written in stages between 1937 and 1949, The Lord of the Rings is one of the best-selling novels ever written, with over 150 million copies sold.", "https://picsum.photos/200/300", "The Lord of the Rings", "Fantasy", null, 20, null },
                    { new Guid("e54da784-8c22-454b-9d37-d0cade9cd604"), "The Picture of Dorian Gray is a philosophical novel by Oscar Wilde, first published complete in the July 1890 issue of Lippincott's Monthly Magazine. Fearing the story was indecent, the magazine's editor deleted roughly five hundred words before publication. The work's initial reception was mixed, with some reviewers praising its literary merits and others condemning the story's immoral content.", "https://picsum.photos/200/300", "The Picture of Dorian Gray", "Horror", null, 10, null },
                    { new Guid("f3303859-1a1f-43e9-883a-533ce3b18329"), "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school, and with the help of his friends, Harry faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.", "https://picsum.photos/200/300", "Harry Potter and the Philosopher's Stone", "Fantasy", null, 15, null },
                    { new Guid("f693294b-8b62-44fa-841c-282f521810ac"), "The Hitchhiker's Guide to the Galaxy is a comedy science fiction series created by Douglas Adams. Originally a radio comedy broadcast on BBC Radio 4 in 1978, it was later adapted to other formats, and over several years it gradually became an international multi-media phenomenon.", "https://picsum.photos/200/300", "The Hitchhiker's Guide to the Galaxy", "Comedy", null, 10, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4c9c839f-cc5e-4fc2-a9c6-66cef233e462", "1d2e2be8-5433-4546-85c4-19ceba8ffa5c" });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "OwnerId" },
                values: new object[] { new Guid("cb78ef1e-7f0d-4269-b9f2-12148199b7c0"), "1d2e2be8-5433-4546-85c4-19ceba8ffa5c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0b0b67f-aa4a-4675-9ee3-8fe197f5e2e3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c9c839f-cc5e-4fc2-a9c6-66cef233e462", "1d2e2be8-5433-4546-85c4-19ceba8ffa5c" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e48b5f3-0a38-4d8a-80eb-c8513941cd70"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("186cc67d-8a63-4b67-a966-72a8bfaa32cb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("34fc5a86-719b-4dd5-8665-9602deabf0f6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55016735-c27b-4fea-970f-00fa92bd09c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("60b0b581-55de-46a5-a227-d07f2de86a6c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("85096c0e-3c09-4fcb-a674-ae09a210570d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e00eb059-fb1c-4695-bc61-40cbce4c5a0f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e54da784-8c22-454b-9d37-d0cade9cd604"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f3303859-1a1f-43e9-883a-533ce3b18329"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f693294b-8b62-44fa-841c-282f521810ac"));

            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: new Guid("cb78ef1e-7f0d-4269-b9f2-12148199b7c0"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c9c839f-cc5e-4fc2-a9c6-66cef233e462");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d2e2be8-5433-4546-85c4-19ceba8ffa5c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3039993d-dd00-41c2-b5e6-f44f40fdca3b", "0af3a44d-ea0b-4c93-907b-b1a9d69f3b75", "User", "USER" },
                    { "5fc9fc47-01a5-47c9-8509-64f9973e8af6", "dba65ac0-6d70-48a7-ba26-243df30de17e", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "edb3b8f2-d34d-4c95-92af-2690f79cd841", 0, "2f8bd967-e670-4b29-9583-f7a5a479b851", "admin@test.com", true, "Admin", "Admin", false, null, "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEHoB7DA0eLLSvrJvWnIcSU0/49QyuEBYMuW+Cky5F9/wJmkopNidE9hWHugdQg6E8Q==", null, false, "cddbfda1-61ef-4de9-bd91-ba45c9251e11", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5fc9fc47-01a5-47c9-8509-64f9973e8af6", "edb3b8f2-d34d-4c95-92af-2690f79cd841" });

            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "OwnerId" },
                values: new object[] { new Guid("248092de-f108-47ad-bced-05fac6eb3a11"), "edb3b8f2-d34d-4c95-92af-2690f79cd841" });
        }
    }
}
