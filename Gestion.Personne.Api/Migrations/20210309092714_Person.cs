using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion.Personne.Api.Migrations
{
    public partial class Person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListPersonnes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false, defaultValueSql: "NEWID()"),
                    Nom = table.Column<string>(type: "TEXT", nullable: false),
                    Prenom = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListPersonnes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ListPersonnes",
                columns: new[] { "Id", "Nom", "Prenom" },
                values: new object[] { new Guid("0889ae07-af92-4969-a0de-60d55f690298"), "Liuzzo", "Giosue" });

            migrationBuilder.InsertData(
                table: "ListPersonnes",
                columns: new[] { "Id", "Nom", "Prenom" },
                values: new object[] { new Guid("75e655e3-dfc6-4c4d-920f-0ee31d11b2bd"), "Natale", "Elisa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListPersonnes");
        }
    }
}
