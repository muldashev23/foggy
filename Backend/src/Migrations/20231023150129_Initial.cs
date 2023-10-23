using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "PasswordHash", "PasswordSalt", "Role", "Surname" },
                values: new object[] { 1, "admin@gmail.com", "murat", new byte[] { 239, 73, 208, 13, 27, 71, 4, 242, 132, 255, 224, 255, 255, 249, 127, 90, 228, 135, 218, 118, 195, 177, 238, 169, 197, 194, 166, 37, 209, 187, 51, 250, 150, 104, 203, 99, 93, 243, 178, 117, 130, 252, 198, 25, 157, 243, 158, 126, 109, 15, 236, 71, 114, 4, 55, 215, 232, 54, 30, 96, 92, 83, 27, 228 }, new byte[] { 253, 23, 229, 154, 53, 74, 212, 117, 65, 126, 142, 81, 80, 88, 166, 217, 183, 19, 136, 131, 108, 72, 213, 104, 49, 84, 119, 126, 48, 127, 197, 79, 155, 207, 59, 145, 245, 141, 163, 5, 99, 117, 4, 80, 67, 136, 40, 84, 218, 121, 231, 38, 102, 254, 72, 123, 15, 112, 78, 106, 124, 53, 150, 118, 140, 217, 14, 240, 62, 246, 47, 213, 100, 189, 185, 18, 208, 239, 155, 111, 164, 42, 130, 220, 17, 62, 4, 244, 16, 161, 99, 251, 67, 52, 120, 221, 14, 13, 0, 149, 117, 51, 122, 39, 247, 107, 194, 15, 32, 170, 107, 98, 153, 149, 254, 34, 75, 77, 99, 47, 215, 102, 229, 157, 73, 124, 248, 129 }, "Manager", "muldashev" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
