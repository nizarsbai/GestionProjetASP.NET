using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionProjet.Services.ProjectAPI.Migrations
{
    public partial class migrateGestionProjets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    employeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    salaire = table.Column<double>(type: "float", nullable: false),
                    iamageURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.employeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employes");
        }
    }
}
