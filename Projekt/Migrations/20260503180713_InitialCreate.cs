using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projekt.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CardNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PackName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "Name", "PackName" },
                values: new object[,]
                {
                    { 1, "001", "BLUBERINI OCTOPUSINI", "brainrot" },
                    { 2, "002", "TIRILICALICA TIRILICALACO", "brainrot" },
                    { 3, "003", "COCCODRILLO FORMAGGIOSO", "brainrot" },
                    { 4, "004", "PANBRONCIO AL LATTE", "brainrot" },
                    { 5, "005", "MARCO POLLO", "brainrot" },
                    { 6, "006", "OCA DEL ROVER LUNARE", "brainrot" },
                    { 7, "007", "GANGSTER FOOTERA", "brainrot" },
                    { 8, "008", "CACTO IPPOPOTAMO", "brainrot" },
                    { 9, "009", "RAPARRAPA CHE PARA", "brainrot" },
                    { 10, "010", "CERVELLO PUDDING", "brainrot" },
                    { 11, "011", "GNAMMO SLAMMO E SGOMMO", "brainrot" },
                    { 12, "012", "AEROMUCCA ARMATA", "brainrot" },
                    { 13, "013", "CAPRAMPANTE SOTTOPANCA", "brainrot" },
                    { 14, "014", "FRULLI FRULLA", "brainrot" },
                    { 15, "015", "CROCODILO POTATINO", "brainrot" },
                    { 16, "016", "BONECA AMBALABU", "brainrot" },
                    { 17, "017", "TRIPPA TROPPA TRALALA LIRI LIRÀ TUNG TUNG SAHUR BONECA TUNG TUNG TRALALELO TRIPPI TROPPA CROCODINA", "brainrot" },
                    { 18, "018", "RUGGINATO LUPOGT", "brainrot" },
                    { 19, "019", "BALLERINO LOLOLO", "brainrot" },
                    { 20, "020", "LA VACCA ATOMO ATOMITA", "brainrot" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PackName_CardNumber",
                table: "Cards",
                columns: new[] { "PackName", "CardNumber" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");
        }
    }
}
