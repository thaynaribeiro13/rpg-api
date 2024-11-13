using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoCorrecaoPerfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "TB_USUARIOS",
                type: "Varchar(200)",
                maxLength: 200,
                nullable: true,
                defaultValue: "Jogador",
                oldClrType: typeof(string),
                oldType: "Varchar(200)",
                oldMaxLength: 200,
                oldDefaultValue: "Jogador");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "TB_USUARIOS",
                type: "Varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.CreateTable(
                name: "TB_DISPUTAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dt_Disputa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AtacanteId = table.Column<int>(type: "int", nullable: false),
                    OponenteId = table.Column<int>(type: "int", nullable: false),
                    Tx_Narracao = table.Column<string>(type: "Varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DISPUTAS", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 27, 129, 24, 72, 188, 74, 0, 99, 193, 137, 24, 95, 148, 100, 202, 228, 116, 175, 246, 138, 76, 136, 207, 248, 171, 44, 199, 6, 234, 170, 61, 36, 227, 123, 119, 140, 21, 40, 136, 176, 69, 81, 101, 59, 96, 15, 143, 175, 146, 134, 89, 71, 227, 250, 53, 35, 160, 129, 208, 147, 118, 220, 158, 23 }, new byte[] { 19, 54, 230, 99, 96, 221, 43, 222, 118, 8, 153, 247, 71, 152, 115, 236, 38, 99, 131, 247, 52, 51, 21, 136, 146, 130, 143, 81, 137, 180, 209, 132, 6, 222, 55, 128, 140, 31, 12, 184, 25, 227, 129, 175, 214, 60, 140, 182, 21, 185, 177, 53, 146, 83, 41, 2, 162, 109, 179, 122, 158, 161, 219, 232, 180, 29, 161, 30, 50, 87, 1, 116, 63, 117, 10, 237, 37, 191, 152, 1, 81, 221, 189, 126, 125, 127, 109, 201, 0, 121, 245, 56, 167, 186, 251, 163, 213, 5, 94, 17, 230, 65, 68, 237, 62, 127, 25, 251, 29, 68, 106, 166, 104, 212, 126, 89, 101, 144, 38, 51, 8, 80, 88, 140, 49, 43, 175, 92 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_DISPUTAS");

            migrationBuilder.AlterColumn<string>(
                name: "Perfil",
                table: "TB_USUARIOS",
                type: "Varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "Jogador",
                oldClrType: typeof(string),
                oldType: "Varchar(200)",
                oldMaxLength: 200,
                oldNullable: true,
                oldDefaultValue: "Jogador");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "TB_USUARIOS",
                type: "Varchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "Varchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 9, 238, 56, 68, 157, 95, 62, 130, 167, 223, 227, 46, 51, 212, 19, 150, 120, 159, 64, 240, 106, 240, 219, 71, 9, 193, 251, 33, 114, 17, 40, 2, 110, 9, 18, 31, 245, 252, 79, 178, 246, 172, 180, 168, 122, 234, 242, 177, 52, 116, 169, 148, 185, 217, 151, 166, 157, 80, 31, 250, 27, 58, 121, 54 }, new byte[] { 187, 22, 32, 98, 214, 63, 34, 150, 90, 154, 192, 28, 176, 76, 131, 176, 27, 114, 71, 161, 99, 166, 77, 236, 122, 44, 94, 9, 229, 167, 89, 81, 25, 208, 91, 0, 230, 61, 22, 229, 58, 236, 39, 90, 220, 108, 74, 50, 34, 3, 191, 188, 74, 64, 30, 129, 66, 234, 110, 39, 59, 231, 79, 253, 18, 161, 216, 173, 116, 163, 8, 216, 151, 214, 12, 245, 164, 110, 32, 46, 25, 229, 153, 169, 34, 133, 29, 92, 21, 189, 174, 234, 25, 113, 109, 143, 210, 71, 128, 143, 236, 135, 27, 198, 16, 107, 143, 182, 246, 99, 24, 14, 188, 222, 203, 49, 110, 105, 111, 136, 78, 48, 207, 169, 32, 151, 178, 244 } });
        }
    }
}
