using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ZavrsniRad.Migrations
{
    /// <inheritdoc />
    public partial class test02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOnSale = table.Column<bool>(type: "bit", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Mojang is a visionary Swedish video game company celebrated for its masterpiece, Minecraft, an immensely popular open-world sandbox game that sparks boundless creativity. Embracing community engagement and relentless innovation, Mojang stands tall as a trailblazer in the gaming industry.", "Mojang" },
                    { 2, "Perfuse Entertainment is a visionary gaming company, crafting immersive experiences with boundless creativity. Their talented team of developers and designers brings captivating games to life, leaving players enchanted and hungry for more. With a passion for storytelling and innovation, Perfuse Entertainment shines as a rising star in the gaming world, delighting audiences worldwide with their stunning creations.", "Perfuse Entertainment" },
                    { 3, "Bandai Namco Entertainment is a gaming powerhouse, known for crafting unforgettable experiences that capture hearts worldwide. With a legacy dating back to the arcade era, they continue to delight players with iconic franchises and cutting-edge titles, making them a beloved and influential presence in the gaming community.", "Bandai Namco Entertainment" },
                    { 4, "Criterion Software, a trailblazing gaming company, sets new standards in visual excellence and interactive innovation. Renowned for their cutting-edge technology and tools, they empower developers globally. With a passion for elevating gaming experiences, Criterion Software continues to create visually stunning and immersive games that captivate players worldwide.", "Criterion Software" },
                    { 5, "Nintendo, the iconic Japanese gaming company, is a beacon of innovation and creativity. With legendary franchises like Super Mario and Pokémon, they've enchanted players of all ages for generations. Renowned for their family-friendly approach and groundbreaking consoles, Nintendo continues to spread joy and create cherished memories worldwide.", "Nintendo" },
                    { 6, "Ubisoft, a gaming global giant, creates captivating and imaginative experiences. Their iconic franchises like Assassin's Creed and Far Cry have won the hearts of players worldwide. With a pioneering spirit, Ubisoft continues to shape the future of interactive entertainment, delivering unforgettable adventures and pushing creative boundaries.", "Ubisoft" },
                    { 7, "Obsidian Entertainment, a revered game development studio, weaves captivating role-playing experiences. With a flair for storytelling, their titles like Fallout: New Vegas and The Outer Worlds earn critical acclaim and a devoted fan base. Setting new RPG standards, Obsidian's engaging narratives and immersive worlds enchant gamers worldwide.", "Obsidian Entertainment" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Survival" },
                    { 2, "Fighter" },
                    { 3, "Racing" },
                    { 4, "Adventure" },
                    { 5, "Sport" },
                    { 6, "RPG" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "PC" },
                    { 2, "XBOX" },
                    { 3, "PlayStation" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mojang Studios" },
                    { 2, "Perfuse Entertainment" },
                    { 3, "BNE Entertainment" },
                    { 4, "Electronic Arts" },
                    { 5, "Nintendo" },
                    { 6, "Ubisoft" },
                    { 7, "Bethesda Softworks" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "AuthorId", "Description", "GenreId", "IsOnSale", "Name", "PlatformId", "Price", "PublisherId", "Thumbnail" },
                values: new object[,]
                {
                    { 1, 1, "The gameplay of Minecraft offers players a high degree of freedom and creativity. They can gather resources by mining blocks, such as wood, stone, and ores, which can be used to craft tools, weapons, and building materials. The crafting system in Minecraft allows players to combine different resources in a specific pattern to create various items and tools.", 1, false, "Minecraft", 1, 19.99m, 1, "/img/minecraftthumbnail.jpg" },
                    { 2, 2, "In Golf It, players navigate through a series of imaginative and challenging mini-golf courses. The game offers a variety of beautifully designed and visually captivating environments, including lush green landscapes, whimsical fantasy worlds, and even unconventional settings like space or underwater.", 5, false, "Golf It", 1, 9.99m, 2, "/img/GolfItThumbnail.jpeg" },
                    { 3, 3, "Tekken offers various gameplay modes to cater to different player preferences. The Arcade mode allows players to follow a character-specific story arc, progressing through a series of battles against AI-controlled opponents. The Versus mode enables local multiplayer, pitting players against each other in thrilling head-to-head matches. Tekken also includes an expansive Practice mode, allowing players to hone their skills, learn new moves, and experiment with combos and strategies.", 2, true, "Tekken 7", 3, 28.45m, 3, "/img/tekkenthumbnail.jpg" },
                    { 4, 4, "In the world of Need for Speed, players step into the shoes of street racers, navigating through vast open-world environments or tightly designed tracks in a variety of exotic, high-performance cars. The franchise offers a mix of both legal and illegal racing experiences, allowing players to compete in sanctioned events or engage in illicit street races.", 3, false, "Need For Speed: Most Wanted", 2, 19.99m, 4, "/img/nfsmwthumbnail.jpg" },
                    { 5, 5, "The core gameplay of Super Smash Bros revolves around intense battles between multiple characters on interactive stages. Players control their chosen character and attempt to knock their opponents off the stage to score points and secure victories. The game features a wide array of attacks, special moves, and defensive maneuvers that vary depending on the character being played.", 2, false, "Super Smash Bros", 3, 35.99m, 5, "/img/supersmashbrosthumbnail.webp" },
                    { 6, 6, "The gameplay of Black Flag combines the series' signature historical exploration and stealth mechanics with the new and exhilarating element of naval combat. Players can freely traverse the Caribbean Sea on Edward's ship, the Jackdaw, engaging in intense naval battles, looting enemy vessels, and even boarding enemy ships to engage in close-quarters combat.", 4, true, "Assassin's Creed: Black Flag", 2, 8.49m, 6, "/img/acblackflagthumbnail.jpg" },
                    { 7, 7, "Fallout: New Vegas offers a vast and immersive open-world experience. Players can freely explore the expansive desert landscape, encountering various factions, mutated creatures, and morally ambiguous characters along the way. The game presents players with multiple branching paths and a multitude of choices, allowing for a high degree of player agency and influencing the outcome of the story.", 6, false, "Fallout: New Vegas", 1, 9.99m, 7, "/img/falloutnvthumbnail.jpeg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_AuthorId",
                table: "Games",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreId",
                table: "Games",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_PlatformId",
                table: "Games",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_PublisherId",
                table: "Games",
                column: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
