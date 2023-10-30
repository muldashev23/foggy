using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class NewTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Shifts_AppUserId",
                table: "Shifts");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 25, 145, 204, 95, 205, 127, 232, 12, 70, 23, 39, 74, 9, 33, 93, 159, 206, 52, 19, 75, 24, 21, 70, 40, 2, 76, 102, 221, 34, 62, 238, 30, 190, 167, 202, 195, 182, 119, 169, 100, 240, 80, 112, 161, 215, 189, 91, 43, 251, 179, 91, 219, 141, 50, 52, 104, 173, 6, 17, 249, 244, 227, 82, 29 }, new byte[] { 177, 87, 99, 225, 222, 181, 72, 176, 145, 5, 187, 61, 104, 135, 111, 11, 230, 226, 173, 246, 49, 248, 189, 175, 199, 45, 122, 205, 195, 109, 223, 47, 15, 248, 181, 225, 38, 92, 167, 216, 179, 170, 142, 239, 85, 167, 52, 87, 163, 104, 200, 155, 117, 201, 203, 61, 206, 82, 100, 168, 215, 214, 75, 61, 49, 238, 109, 3, 98, 35, 218, 55, 179, 204, 131, 162, 54, 64, 168, 200, 78, 246, 42, 210, 214, 55, 96, 103, 243, 104, 40, 104, 94, 190, 106, 215, 201, 98, 42, 178, 142, 69, 97, 212, 37, 51, 19, 24, 155, 178, 135, 232, 133, 134, 56, 103, 208, 242, 53, 98, 87, 94, 168, 224, 239, 237, 160, 37 } });

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_AppUserId",
                table: "Shifts",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Shifts_AppUserId",
                table: "Shifts");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 239, 0, 5, 71, 31, 200, 197, 19, 136, 169, 253, 9, 66, 8, 32, 179, 112, 216, 88, 49, 240, 34, 63, 160, 99, 164, 213, 0, 124, 107, 5, 125, 68, 176, 8, 84, 220, 244, 84, 48, 255, 74, 252, 203, 83, 191, 182, 46, 154, 141, 172, 84, 71, 206, 215, 189, 235, 35, 97, 230, 10, 240, 114, 73 }, new byte[] { 22, 150, 15, 38, 48, 185, 132, 246, 142, 245, 175, 126, 139, 0, 127, 196, 118, 227, 192, 130, 14, 98, 254, 33, 16, 23, 236, 101, 139, 231, 213, 193, 142, 0, 64, 62, 20, 177, 6, 227, 62, 30, 176, 119, 57, 203, 111, 239, 145, 178, 58, 4, 93, 234, 71, 100, 216, 132, 173, 126, 15, 107, 19, 76, 48, 18, 179, 230, 155, 55, 255, 123, 143, 243, 91, 217, 235, 45, 217, 204, 168, 143, 111, 153, 128, 28, 79, 210, 146, 36, 52, 238, 191, 31, 91, 17, 248, 162, 29, 226, 96, 99, 224, 164, 195, 84, 56, 172, 170, 121, 13, 167, 199, 63, 127, 248, 107, 237, 209, 38, 110, 99, 46, 6, 83, 49, 37, 117 } });

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_AppUserId",
                table: "Shifts",
                column: "AppUserId",
                unique: true);
        }
    }
}
