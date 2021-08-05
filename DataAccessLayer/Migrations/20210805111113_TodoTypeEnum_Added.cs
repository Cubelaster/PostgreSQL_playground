using Core.Enums;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class TodoTypeEnum_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:todo_type", "administrative,technical,hr");

            migrationBuilder.AddColumn<TodoType>(
                name: "TodoType",
                table: "TodoItems",
                type: "todo_type",
                nullable: false,
                defaultValue: TodoType.Administrative);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TodoType",
                table: "TodoItems");

            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:Enum:todo_type", "administrative,technical,hr");
        }
    }
}
