using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaFuncioanrioMVC.Migrations
{
    /// <inheritdoc />
    public partial class CriarBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelaFuncionario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salarioBase = table.Column<double>(type: "float", nullable: false),
                    cargo = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaFuncionario", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaFuncionario");
        }
    }
}
