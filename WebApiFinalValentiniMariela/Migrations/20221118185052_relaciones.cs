using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFinalValentiniMariela.Migrations
{
    public partial class relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Hospital_Hospital_Cod1",
                table: "Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Doctor_Hospital_Cod1",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Hospital_Cod1",
                table: "Doctor");

            migrationBuilder.AddColumn<int>(
                name: "Hopital_Cod",
                table: "Doctor",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Hospital_Cod1",
                table: "Doctor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Hospital_Cod1",
                table: "Doctor",
                column: "Hospital_Cod1");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Hospital_Hospital_Cod1",
                table: "Doctor",
                column: "Hospital_Cod1",
                principalTable: "Hospital",
                principalColumn: "Hospital_Cod",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
