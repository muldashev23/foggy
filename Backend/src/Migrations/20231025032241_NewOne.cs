using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class NewOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea");

            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 239, 0, 5, 71, 31, 200, 197, 19, 136, 169, 253, 9, 66, 8, 32, 179, 112, 216, 88, 49, 240, 34, 63, 160, 99, 164, 213, 0, 124, 107, 5, 125, 68, 176, 8, 84, 220, 244, 84, 48, 255, 74, 252, 203, 83, 191, 182, 46, 154, 141, 172, 84, 71, 206, 215, 189, 235, 35, 97, 230, 10, 240, 114, 73 }, new byte[] { 22, 150, 15, 38, 48, 185, 132, 246, 142, 245, 175, 126, 139, 0, 127, 196, 118, 227, 192, 130, 14, 98, 254, 33, 16, 23, 236, 101, 139, 231, 213, 193, 142, 0, 64, 62, 20, 177, 6, 227, 62, 30, 176, 119, 57, 203, 111, 239, 145, 178, 58, 4, 93, 234, 71, 100, 216, 132, 173, 126, 15, 107, 19, 76, 48, 18, 179, 230, 155, 55, 255, 123, 143, 243, 91, 217, 235, 45, 217, 204, 168, 143, 111, 153, 128, 28, 79, 210, 146, 36, 52, 238, 191, 31, 91, 17, 248, 162, 29, 226, 96, 99, 224, 164, 195, 84, 56, 172, 170, 121, 13, 167, 199, 63, 127, 248, 107, 237, 209, 38, 110, 99, 46, 6, 83, 49, 37, 117 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 79, 191, 232, 213, 129, 251, 100, 198, 40, 171, 235, 206, 7, 45, 170, 146, 36, 141, 150, 8, 254, 118, 118, 119, 235, 232, 202, 53, 227, 187, 129, 122, 209, 174, 161, 239, 115, 149, 182, 68, 158, 146, 71, 32, 185, 243, 47, 86, 66, 31, 74, 224, 200, 57, 67, 80, 66, 254, 99, 91, 39, 212, 248, 171 }, new byte[] { 149, 213, 226, 56, 221, 115, 232, 173, 149, 219, 165, 194, 114, 34, 104, 240, 120, 234, 152, 14, 224, 61, 229, 48, 23, 250, 83, 20, 55, 38, 139, 198, 147, 83, 37, 203, 5, 104, 140, 246, 213, 69, 34, 119, 137, 119, 174, 135, 43, 56, 131, 189, 85, 249, 186, 113, 134, 161, 126, 205, 55, 150, 249, 94, 243, 232, 223, 68, 97, 101, 40, 60, 109, 34, 52, 71, 244, 57, 247, 251, 178, 235, 32, 110, 50, 0, 10, 171, 120, 205, 107, 117, 60, 24, 239, 85, 14, 118, 159, 92, 211, 54, 159, 147, 58, 12, 252, 219, 71, 97, 82, 19, 160, 182, 80, 144, 27, 180, 168, 233, 40, 7, 126, 28, 111, 248, 190, 12 } });
        }
    }
}
