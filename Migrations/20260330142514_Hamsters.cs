using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Person.Migrations
{
    /// <inheritdoc />
    public partial class Hamsters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HamsterId",
                table: "ConcretePerson",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 100, nullable: false),
                    Specie = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpottedAts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpottedAts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConcretePersonSpottedAt",
                columns: table => new
                {
                    PeopleId = table.Column<int>(type: "int", nullable: false),
                    spottedAtId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConcretePersonSpottedAt", x => new { x.PeopleId, x.spottedAtId });
                    table.ForeignKey(
                        name: "FK_ConcretePersonSpottedAt_ConcretePerson_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "ConcretePerson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConcretePersonSpottedAt_SpottedAts_spottedAtId",
                        column: x => x.spottedAtId,
                        principalTable: "SpottedAts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConcretePerson_HamsterId",
                table: "ConcretePerson",
                column: "HamsterId",
                unique: true,
                filter: "[HamsterId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ConcretePersonSpottedAt_spottedAtId",
                table: "ConcretePersonSpottedAt",
                column: "spottedAtId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConcretePerson_Hamsters_HamsterId",
                table: "ConcretePerson",
                column: "HamsterId",
                principalTable: "Hamsters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConcretePerson_Hamsters_HamsterId",
                table: "ConcretePerson");

            migrationBuilder.DropTable(
                name: "ConcretePersonSpottedAt");

            migrationBuilder.DropTable(
                name: "Hamsters");

            migrationBuilder.DropTable(
                name: "SpottedAts");

            migrationBuilder.DropIndex(
                name: "IX_ConcretePerson_HamsterId",
                table: "ConcretePerson");

            migrationBuilder.DropColumn(
                name: "HamsterId",
                table: "ConcretePerson");
        }
    }
}
