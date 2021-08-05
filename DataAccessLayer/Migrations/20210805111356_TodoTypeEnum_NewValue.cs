using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class TodoTypeEnum_NewValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:todo_type", "administrative,technical,hr,something")
                .OldAnnotation("Npgsql:Enum:todo_type", "administrative,technical,hr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:todo_type", "administrative,technical,hr")
                .OldAnnotation("Npgsql:Enum:todo_type", "administrative,technical,hr,something");
        }
    }
}
