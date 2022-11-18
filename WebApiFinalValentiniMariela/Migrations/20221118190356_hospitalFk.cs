using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFinalValentiniMariela.Migrations
{
    public partial class hospitalFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Hospital_Hopital_Cod",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_Hopital_Cod",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Hopital_Cod",
                table: "Doctor");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Hospital_Cod",
                table: "Doctor",
                column: "Hospital_Cod");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Hospital_Hospital_Cod",
                table: "Doctor",
                column: "Hospital_Cod",
                principalTable: "Hospital",
                principalColumn: "Hospital_Cod",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Hospital_Hospital_Cod",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_Hospital_Cod",
                table: "Doctor");

            migrationBuilder.AddColumn<int>(
                name: "Hopital_Cod",
                table: "Doctor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Hopital_Cod",
                table: "Doctor",
                column: "Hopital_Cod");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Hospital_Hopital_Cod",
                table: "Doctor",
                column: "Hopital_Cod",
                principalTable: "Hospital",
                principalColumn: "Hospital_Cod",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
