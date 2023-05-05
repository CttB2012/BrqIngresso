using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BRQ_Ingresso.Migrations
{
    /// <inheritdoc />
    public partial class TesteMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_EnderecoUsuarios_EnderecoUsuarioIdEndereco",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_EnderecoUsuarioIdEndereco",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EnderecoUsuarioIdEndereco",
                table: "Usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "IdEndereco",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "IdUsuario",
                table: "EnderecoUsuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "IdEndereco",
                keyValue: null,
                column: "IdEndereco",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "IdEndereco",
                table: "Usuarios",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "EnderecoUsuarioIdEndereco",
                table: "Usuarios",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "EnderecoUsuarios",
                keyColumn: "IdUsuario",
                keyValue: null,
                column: "IdUsuario",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "IdUsuario",
                table: "EnderecoUsuarios",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EnderecoUsuarioIdEndereco",
                table: "Usuarios",
                column: "EnderecoUsuarioIdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_EnderecoUsuarios_EnderecoUsuarioIdEndereco",
                table: "Usuarios",
                column: "EnderecoUsuarioIdEndereco",
                principalTable: "EnderecoUsuarios",
                principalColumn: "IdEndereco");
        }
    }
}
