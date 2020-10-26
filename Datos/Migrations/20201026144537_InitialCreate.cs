using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apoyos",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Departamento = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    valorApoyo = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Modalidad = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apoyos", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Identificacion = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    ApoyoCodigo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Identificacion);
                    table.ForeignKey(
                        name: "FK_Personas_Apoyos_ApoyoCodigo",
                        column: x => x.ApoyoCodigo,
                        principalTable: "Apoyos",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_ApoyoCodigo",
                table: "Personas",
                column: "ApoyoCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Apoyos");
        }
    }
}
