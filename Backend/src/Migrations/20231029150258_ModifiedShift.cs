using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedShift : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayNum",
                table: "Shifts");

            migrationBuilder.DropColumn(
                name: "WeekNum",
                table: "Shifts");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 71, 229, 137, 87, 209, 176, 16, 255, 1, 172, 48, 236, 233, 174, 157, 204, 44, 81, 50, 189, 80, 161, 149, 164, 171, 62, 101, 196, 136, 5, 214, 175, 106, 32, 119, 137, 201, 21, 163, 120, 225, 108, 33, 145, 170, 124, 199, 3, 111, 160, 171, 102, 30, 169, 34, 138, 148, 242, 108, 109, 84, 104, 181, 230 }, new byte[] { 74, 34, 181, 247, 227, 177, 250, 63, 182, 37, 24, 148, 162, 87, 3, 231, 12, 212, 167, 158, 38, 140, 141, 94, 21, 238, 69, 217, 57, 234, 85, 158, 55, 217, 113, 119, 231, 88, 134, 43, 55, 196, 62, 10, 253, 107, 54, 48, 122, 92, 14, 145, 233, 135, 1, 103, 168, 83, 201, 42, 35, 44, 175, 157, 122, 171, 178, 238, 228, 174, 32, 172, 157, 81, 107, 181, 20, 142, 183, 32, 85, 90, 236, 95, 56, 86, 247, 128, 120, 51, 120, 157, 116, 220, 82, 180, 84, 150, 175, 226, 132, 188, 68, 140, 241, 60, 242, 70, 78, 154, 169, 113, 69, 97, 145, 163, 166, 45, 233, 176, 31, 14, 252, 108, 237, 114, 2, 134 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DayNum",
                table: "Shifts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WeekNum",
                table: "Shifts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 25, 145, 204, 95, 205, 127, 232, 12, 70, 23, 39, 74, 9, 33, 93, 159, 206, 52, 19, 75, 24, 21, 70, 40, 2, 76, 102, 221, 34, 62, 238, 30, 190, 167, 202, 195, 182, 119, 169, 100, 240, 80, 112, 161, 215, 189, 91, 43, 251, 179, 91, 219, 141, 50, 52, 104, 173, 6, 17, 249, 244, 227, 82, 29 }, new byte[] { 177, 87, 99, 225, 222, 181, 72, 176, 145, 5, 187, 61, 104, 135, 111, 11, 230, 226, 173, 246, 49, 248, 189, 175, 199, 45, 122, 205, 195, 109, 223, 47, 15, 248, 181, 225, 38, 92, 167, 216, 179, 170, 142, 239, 85, 167, 52, 87, 163, 104, 200, 155, 117, 201, 203, 61, 206, 82, 100, 168, 215, 214, 75, 61, 49, 238, 109, 3, 98, 35, 218, 55, 179, 204, 131, 162, 54, 64, 168, 200, 78, 246, 42, 210, 214, 55, 96, 103, 243, 104, 40, 104, 94, 190, 106, 215, 201, 98, 42, 178, 142, 69, 97, 212, 37, 51, 19, 24, 155, 178, 135, 232, 133, 134, 56, 103, 208, 242, 53, 98, 87, 94, 168, 224, 239, 237, 160, 37 } });
        }
    }
}
