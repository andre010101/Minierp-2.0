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
                name: "notas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    infoNota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preco = table.Column<int>(type: "int", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notasid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_clientes_notas_notasid",
                        column: x => x.notasid,
                        principalTable: "notas",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "fornecedor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notasid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor", x => x.id);
                    table.ForeignKey(
                        name: "FK_fornecedor_notas_Notasid",
                        column: x => x.Notasid,
                        principalTable: "notas",
                        principalColumn: "id");
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
                    fornecedorid = table.Column<int>(type: "int", nullable: false),
                    clientesid = table.Column<int>(type: "int", nullable: false),
                    notasid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.id);
                    table.ForeignKey(
                        name: "FK_produtos_clientes_clientesid",
                        column: x => x.clientesid,
                        principalTable: "clientes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_produtos_fornecedor_fornecedorid",
                        column: x => x.fornecedorid,
                        principalTable: "fornecedor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produtos_notas_notasid",
                        column: x => x.notasid,
                        principalTable: "notas",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_notasid",
                table: "clientes",
                column: "notasid");

            migrationBuilder.CreateIndex(
                name: "IX_fornecedor_Notasid",
                table: "fornecedor",
                column: "Notasid");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_clientesid",
                table: "produtos",
                column: "clientesid");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_fornecedorid",
                table: "produtos",
                column: "fornecedorid");

            migrationBuilder.CreateIndex(
                name: "IX_produtos_notasid",
                table: "produtos",
                column: "notasid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "produtos");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "fornecedor");

            migrationBuilder.DropTable(
                name: "notas");
        }
    }
}
