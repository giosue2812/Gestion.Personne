using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Global.Migrations
{
    public partial class Person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListPersons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListPersons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ListPersons",
                columns: new[] { "Id", "Nom", "Prenom" },
                values: new object[] { new Guid("b384a697-00e0-4cb1-9d5f-0f75e85a323a"), "Liuzzo", "Giosue" });

            migrationBuilder.InsertData(
                table: "ListPersons",
                columns: new[] { "Id", "Nom", "Prenom" },
                values: new object[] { new Guid("bc839b51-4121-445d-9b24-2c2328445807"), "Natale", "Elisa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListPersons");
        }
    }
}
