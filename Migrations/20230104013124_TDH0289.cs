using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TranDucHung289.Migrations
{
    /// <inheritdoc />
    public partial class TDH0289 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TDH0289",
                columns: table => new
                {
                    TDHid = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    TDHName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    TDHGender = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TDH0289", x => x.TDHid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TDH0289");
        }
    }
}
