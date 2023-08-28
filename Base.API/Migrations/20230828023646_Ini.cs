using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Base.API.Migrations
{
    /// <inheritdoc />
    public partial class Ini : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuracoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CidadePix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChavePix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorPequeno = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorMedio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorGrande = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorAdicional = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorEntrega = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuracoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sabor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adicional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tamanho = table.Column<long>(type: "bigint", nullable: false),
                    ValorFinal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataPedido = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sabores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescricaoSabor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sabores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genero = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuracoes");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Sabores");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
