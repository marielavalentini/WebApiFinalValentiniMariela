using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFinalValentiniMariela.Migrations
{
    public partial class CrearBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Doctor_No = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hospital_Cod = table.Column<int>(nullable: false),
                    Apellido = table.Column<string>(type: "varchar(50)", nullable: true),
                    Especialidad = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Doctor_No);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    Hospital_Cod = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(50)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(50)", nullable: true),
                    Num_Camas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Hospital_Cod);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Hospital");
        }
    }
}
