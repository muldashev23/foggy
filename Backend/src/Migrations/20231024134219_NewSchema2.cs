using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class NewSchema2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBarmen",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsShishaMaster",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsBarmen", "IsShishaMaster", "PasswordHash", "PasswordSalt" },
                values: new object[] { false, false, new byte[] { 79, 191, 232, 213, 129, 251, 100, 198, 40, 171, 235, 206, 7, 45, 170, 146, 36, 141, 150, 8, 254, 118, 118, 119, 235, 232, 202, 53, 227, 187, 129, 122, 209, 174, 161, 239, 115, 149, 182, 68, 158, 146, 71, 32, 185, 243, 47, 86, 66, 31, 74, 224, 200, 57, 67, 80, 66, 254, 99, 91, 39, 212, 248, 171 }, new byte[] { 149, 213, 226, 56, 221, 115, 232, 173, 149, 219, 165, 194, 114, 34, 104, 240, 120, 234, 152, 14, 224, 61, 229, 48, 23, 250, 83, 20, 55, 38, 139, 198, 147, 83, 37, 203, 5, 104, 140, 246, 213, 69, 34, 119, 137, 119, 174, 135, 43, 56, 131, 189, 85, 249, 186, 113, 134, 161, 126, 205, 55, 150, 249, 94, 243, 232, 223, 68, 97, 101, 40, 60, 109, 34, 52, 71, 244, 57, 247, 251, 178, 235, 32, 110, 50, 0, 10, 171, 120, 205, 107, 117, 60, 24, 239, 85, 14, 118, 159, 92, 211, 54, 159, 147, 58, 12, 252, 219, 71, 97, 82, 19, 160, 182, 80, 144, 27, 180, 168, 233, 40, 7, 126, 28, 111, 248, 190, 12 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBarmen",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsShishaMaster",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 69, 60, 172, 143, 16, 227, 236, 234, 147, 159, 198, 29, 216, 226, 10, 5, 26, 225, 47, 143, 24, 59, 102, 79, 103, 118, 158, 138, 156, 125, 30, 240, 248, 79, 203, 226, 45, 91, 113, 217, 179, 81, 92, 80, 93, 22, 110, 112, 100, 62, 9, 239, 87, 14, 121, 60, 101, 108, 183, 14, 148, 152, 169, 102 }, new byte[] { 200, 150, 170, 208, 84, 17, 186, 83, 2, 83, 11, 2, 243, 32, 204, 171, 195, 129, 182, 233, 172, 100, 149, 77, 72, 70, 198, 211, 23, 205, 58, 52, 147, 0, 14, 206, 150, 98, 181, 116, 34, 73, 254, 156, 56, 137, 85, 236, 17, 34, 184, 112, 21, 193, 130, 68, 26, 243, 44, 172, 2, 205, 217, 218, 173, 158, 250, 59, 107, 21, 132, 56, 54, 215, 205, 170, 175, 108, 99, 2, 244, 119, 184, 224, 51, 200, 209, 79, 146, 121, 67, 27, 79, 167, 177, 98, 234, 240, 199, 56, 172, 34, 7, 123, 2, 163, 29, 178, 205, 74, 113, 207, 123, 189, 197, 162, 10, 49, 193, 65, 23, 124, 170, 174, 110, 17, 38, 231 } });
        }
    }
}
