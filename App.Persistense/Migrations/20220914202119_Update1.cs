using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Persistense.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PessoaCPF = table.Column<Guid>(type: "uuid", nullable: false),
                    PessoaNome = table.Column<string>(type: "text", nullable: false),
                    PessoaIdade = table.Column<int>(type: "integer", nullable: false),
                    PessoaEndereco = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
