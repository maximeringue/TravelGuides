using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelGuides.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfDays = table.Column<int>(type: "int", nullable: false),
                    Mobility = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Season = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Audience = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelGuideId = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    VisitOrder = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OpeningHours = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_Guides_TravelGuideId",
                        column: x => x.TravelGuideId,
                        principalTable: "Guides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Guides",
                columns: new[] { "Id", "Audience", "Description", "Mobility", "NumberOfDays", "Season", "Title" },
                values: new object[,]
                {
                    { 1, "Entre amis", "Musées et promenades au cœur de Paris.", "À pied", 2, "Printemps", "Week-end à Paris" },
                    { 2, "Famille", "Trois jours de découverte des châteaux.", "Voiture", 3, "Été", "Les châteaux de la Loire" }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Address", "Category", "Day", "Description", "OpeningHours", "Phone", "Title", "TravelGuideId", "VisitOrder", "Website" },
                values: new object[,]
                {
                    { 1, "Adresse de démonstration", "musée", 1, "Découverte des collections.", "Horaires de démonstration", "Non renseigné", "Musée du Louvre", 1, 1, "https://www.louvre.fr" },
                    { 2, "", "parc", 1, "Promenade dans les jardins.", "", "", "Jardin des Tuileries", 1, 2, "" },
                    { 3, "", "activité", 2, "Balade dans le quartier.", "", "", "Montmartre", 1, 1, "" },
                    { 4, "", "château", 1, "Visite du château.", "", "", "Château de Chambord", 2, 1, "" },
                    { 5, "", "château", 2, "Découverte du château et des jardins.", "", "", "Château de Chenonceau", 2, 1, "" },
                    { 6, "", "château", 3, "Visite du château royal.", "", "", "Château d’Amboise", 2, 1, "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_TravelGuideId_Day_VisitOrder",
                table: "Activities",
                columns: new[] { "TravelGuideId", "Day", "VisitOrder" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Guides");
        }
    }
}
