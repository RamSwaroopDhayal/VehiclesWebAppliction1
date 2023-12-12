using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehiclesWebAppliction.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vehiclesModels",
                columns: table => new
                {
                    vehicle_id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    vin = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false),
                    make = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    thumbnail_url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiclesModels", x => x.vehicle_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehiclesModels");
        }
    }
}
