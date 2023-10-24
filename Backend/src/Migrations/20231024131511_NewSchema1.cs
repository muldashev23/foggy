using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class NewSchema1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DayNum = table.Column<int>(type: "integer", nullable: false),
                    TimeStart = table.Column<int>(type: "integer", nullable: false),
                    WeekNum = table.Column<int>(type: "integer", nullable: false),
                    DateOfShift = table.Column<DateOnly>(type: "date", nullable: false),
                    AppUserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 60, 172, 143, 16, 227, 236, 234, 147, 159, 198, 29, 216, 226, 10, 5, 26, 225, 47, 143, 24, 59, 102, 79, 103, 118, 158, 138, 156, 125, 30, 240, 248, 79, 203, 226, 45, 91, 113, 217, 179, 81, 92, 80, 93, 22, 110, 112, 100, 62, 9, 239, 87, 14, 121, 60, 101, 108, 183, 14, 148, 152, 169, 102 }, new byte[] { 200, 150, 170, 208, 84, 17, 186, 83, 2, 83, 11, 2, 243, 32, 204, 171, 195, 129, 182, 233, 172, 100, 149, 77, 72, 70, 198, 211, 23, 205, 58, 52, 147, 0, 14, 206, 150, 98, 181, 116, 34, 73, 254, 156, 56, 137, 85, 236, 17, 34, 184, 112, 21, 193, 130, 68, 26, 243, 44, 172, 2, 205, 217, 218, 173, 158, 250, 59, 107, 21, 132, 56, 54, 215, 205, 170, 175, 108, 99, 2, 244, 119, 184, 224, 51, 200, 209, 79, 146, 121, 67, 27, 79, 167, 177, 98, 234, 240, 199, 56, 172, 34, 7, 123, 2, 163, 29, 178, 205, 74, 113, 207, 123, 189, 197, 162, 10, 49, 193, 65, 23, 124, 170, 174, 110, 17, 38, 231 } });

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_AppUserId",
                table: "Shifts",
                column: "AppUserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 239, 73, 208, 13, 27, 71, 4, 242, 132, 255, 224, 255, 255, 249, 127, 90, 228, 135, 218, 118, 195, 177, 238, 169, 197, 194, 166, 37, 209, 187, 51, 250, 150, 104, 203, 99, 93, 243, 178, 117, 130, 252, 198, 25, 157, 243, 158, 126, 109, 15, 236, 71, 114, 4, 55, 215, 232, 54, 30, 96, 92, 83, 27, 228 }, new byte[] { 253, 23, 229, 154, 53, 74, 212, 117, 65, 126, 142, 81, 80, 88, 166, 217, 183, 19, 136, 131, 108, 72, 213, 104, 49, 84, 119, 126, 48, 127, 197, 79, 155, 207, 59, 145, 245, 141, 163, 5, 99, 117, 4, 80, 67, 136, 40, 84, 218, 121, 231, 38, 102, 254, 72, 123, 15, 112, 78, 106, 124, 53, 150, 118, 140, 217, 14, 240, 62, 246, 47, 213, 100, 189, 185, 18, 208, 239, 155, 111, 164, 42, 130, 220, 17, 62, 4, 244, 16, 161, 99, 251, 67, 52, 120, 221, 14, 13, 0, 149, 117, 51, 122, 39, 247, 107, 194, 15, 32, 170, 107, 98, 153, 149, 254, 34, 75, 77, 99, 47, 215, 102, 229, 157, 73, 124, 248, 129 } });
        }
    }
}
