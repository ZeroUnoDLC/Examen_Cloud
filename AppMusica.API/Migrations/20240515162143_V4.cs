using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppMusica.API.Migrations
{
    /// <inheritdoc />
    public partial class V4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tipo_instrumentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_instrumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instrumentos_musicales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Descuento = table.Column<double>(type: "float", nullable: true),
                    IdTipo_instrumento = table.Column<int>(type: "int", nullable: false),
                    Tipo_InstrumentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrumentos_musicales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instrumentos_musicales_Tipo_instrumentos_Tipo_InstrumentoId",
                        column: x => x.Tipo_InstrumentoId,
                        principalTable: "Tipo_instrumentos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instrumentos_musicales_Tipo_InstrumentoId",
                table: "Instrumentos_musicales",
                column: "Tipo_InstrumentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instrumentos_musicales");

            migrationBuilder.DropTable(
                name: "Tipo_instrumentos");
        }
    }
}
