using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProMulticel.Repository.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formularios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sistema = table.Column<string>(nullable: true),
                    PoderesConcedidos = table.Column<string>(nullable: true),
                    Observacoes = table.Column<string>(nullable: true),
                    DataFormulario = table.Column<DateTime>(nullable: false),
                    Filial = table.Column<string>(nullable: true),
                    ImagemURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formularios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Usuario = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Setor = table.Column<string>(nullable: true),
                    Superior = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuncionarioFormularios",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(nullable: false),
                    FormularioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncionarioFormularios", x => new { x.FormularioId, x.FuncionarioId });
                    table.ForeignKey(
                        name: "FK_FuncionarioFormularios_Formularios_FormularioId",
                        column: x => x.FormularioId,
                        principalTable: "Formularios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FuncionarioFormularios_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FuncionarioFormularios_FuncionarioId",
                table: "FuncionarioFormularios",
                column: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FuncionarioFormularios");

            migrationBuilder.DropTable(
                name: "Formularios");

            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}
