using Microsoft.EntityFrameworkCore.Migrations;

namespace DragonWinterIsComing.Migrations
{
    public partial class AddAtributosPessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Reino",
                table: "Pessoas");

            migrationBuilder.AddColumn<string>(
                name: "Apelido",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cultura",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Pessoas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nascimento",
                table: "Pessoas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apelido",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Cultura",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Nascimento",
                table: "Pessoas");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Pessoas",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Reino",
                table: "Pessoas",
                nullable: false,
                defaultValue: "");
        }
    }
}
