using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserIdFromOriginalUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Додайте всі інші зміни, які вам потрібні окрім видалення 'UserId' з таблиці 'OriginalUrls'

            migrationBuilder.AddColumn<string>(
                name: "NameUserCreated",
                table: "OriginalUrls",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Поверніть зміни, які були внесені у методі Up, якщо необхідно
            migrationBuilder.DropColumn(
                name: "NameUserCreated",
                table: "OriginalUrls");
        }
    }
}
