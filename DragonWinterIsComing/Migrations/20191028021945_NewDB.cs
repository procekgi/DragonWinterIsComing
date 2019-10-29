using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DragonWinterIsComing.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dragoes",
                columns: table => new
                {
                    DragaoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Raca = table.Column<string>(nullable: true),
                    Cor = table.Column<string>(nullable: true),
                    Dieta = table.Column<string>(nullable: true),
                    Habitat = table.Column<string>(nullable: true),
                    Origem = table.Column<string>(nullable: true),
                    Idade = table.Column<int>(nullable: false),
                    CriadoEm = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dragoes", x => x.DragaoId);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    PessoaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    Telefone = table.Column<string>(nullable: true),
                    Casa = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Reino = table.Column<string>(nullable: true),
                    CriadoEm = table.Column<DateTime>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Cdh = table.Column<string>(nullable: true),
                    DragaoId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    PilotoMedia = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.PessoaId);
                    table.ForeignKey(
                        name: "FK_Pessoas_Dragoes_DragaoId",
                        column: x => x.DragaoId,
                        principalTable: "Dragoes",
                        principalColumn: "DragaoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Viagem",
                columns: table => new
                {
                    IdViagem = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocOrigem = table.Column<string>(nullable: true),
                    LocDestino = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    UsuarioPessoaId = table.Column<int>(nullable: true),
                    PilotoPessoaId = table.Column<int>(nullable: true),
                    Nota = table.Column<double>(nullable: false),
                    DragaoId = table.Column<int>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagem", x => x.IdViagem);
                    table.ForeignKey(
                        name: "FK_Viagem_Dragoes_DragaoId",
                        column: x => x.DragaoId,
                        principalTable: "Dragoes",
                        principalColumn: "DragaoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Viagem_Pessoas_PilotoPessoaId",
                        column: x => x.PilotoPessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Viagem_Pessoas_UsuarioPessoaId",
                        column: x => x.UsuarioPessoaId,
                        principalTable: "Pessoas",
                        principalColumn: "PessoaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_DragaoId",
                table: "Pessoas",
                column: "DragaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_DragaoId",
                table: "Viagem",
                column: "DragaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_PilotoPessoaId",
                table: "Viagem",
                column: "PilotoPessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Viagem_UsuarioPessoaId",
                table: "Viagem",
                column: "UsuarioPessoaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Viagem");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Dragoes");
        }
    }
}
