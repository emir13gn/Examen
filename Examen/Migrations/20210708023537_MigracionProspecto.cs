using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen.Migrations
{
    public partial class MigracionProspecto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prospecto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidoP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidoM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numero = table.Column<int>(type: "int", nullable: false),
                    colonia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigoPostal = table.Column<int>(type: "int", nullable: false),
                    telefono = table.Column<int>(type: "int", nullable: false),
                    rfc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prospecto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prospecto");
        }
    }
}
