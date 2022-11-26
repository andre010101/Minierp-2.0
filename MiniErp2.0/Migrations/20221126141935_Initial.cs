using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniErp2._0.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fornecedor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "notas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nfnumero = table.Column<int>(type: "int", nullable: false),
                    infoNota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preco = table.Column<int>(type: "int", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    Fornecedoresid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.id);
                    table.ForeignKey(
                        name: "FK_produtos_fornecedor_Fornecedoresid",
                        column: x => x.Fornecedoresid,
                        principalTable: "fornecedor",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "pedido",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    preco = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    clienteid = table.Column<int>(type: "int", nullable: false),
                    produtosid = table.Column<int>(type: "int", nullable: false),
                    notaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido", x => x.id);
                    table.ForeignKey(
                        name: "FK_pedido_clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "clientes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_pedido_notas_notaid",
                        column: x => x.notaid,
                        principalTable: "notas",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_pedido_produtos_produtosid",
                        column: x => x.produtosid,
                        principalTable: "produtos",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_pedido_clienteid",
                table: "pedido",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_notaid",
                table: "pedido",
                column: "notaid");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_produtosid",
                table: "pedido",
                column: "produtosid");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_Fornecedoresid",
                table: "produtos",
                column: "Fornecedoresid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pedido");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "notas");

            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "fornecedor");
        }
    }
}
