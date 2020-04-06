using Microsoft.EntityFrameworkCore.Migrations;

namespace ProMulticel.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formularios",
                columns: table => new
                {
                    FormularioId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Usuario = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Setor = table.Column<string>(nullable: true),
                    Superior = table.Column<string>(nullable: true),
                    Sistema = table.Column<string>(nullable: true),
                    PoderesConcedidos = table.Column<string>(nullable: true),
                    Observacoes = table.Column<string>(nullable: true),
                    DataFormulario = table.Column<string>(nullable: true),
                    Filial = table.Column<string>(nullable: true),
                    ImagemURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formularios", x => x.FormularioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Formularios");
        }
    }
}
