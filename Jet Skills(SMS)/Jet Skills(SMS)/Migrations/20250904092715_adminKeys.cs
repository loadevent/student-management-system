using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jet_Skills_SMS_.Migrations
{
    /// <inheritdoc />
    public partial class adminKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // The following line is incorrect and causes CS7036.
            // migrationBuilder.DropColumn(migrationBuilder.Sql("ALTER TABLE Admins DROP CONSTRAINT PK_Admins;"));

            // To drop a primary key constraint, use DropPrimaryKey instead:
            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins"
            );

            // The rest of your migration code...
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Admins_UserType_user_type",
            //    table: "Admins");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Admins",
            //    table: "Admins");

            //migrationBuilder.RenameTable(
            //    name: "Admins",
            //    newName: "Admin");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Admins_user_type",
            //    table: "Admin",
            //    newName: "IX_Admin_user_type");

            //migrationBuilder.AlterColumn<string>(
            //    name: "email",
            //    table: "Admin",
            //    type: "varchar(100)",
            //    unicode: false,
            //    maxLength: 100,
            //    nullable: false,
            //    defaultValue: "",
            //    oldClrType: typeof(string),
            //    oldType: "varchar(100)",
            //    oldUnicode: false,
            //    oldMaxLength: 100,
            //    oldNullable: true);

            //migrationBuilder.AlterColumn<int>(
            //    name: "admin_id",
            //    table: "Admin",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Admin",
            //    table: "Admin",
            //    columns: new[] { "admin_id", "email" });

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Admin_UserType_user_type",
            //    table: "Admin",
            //    column: "user_type",
            //    principalTable: "UserType",
            //    principalColumn: "user_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Admin_UserType_user_type",
            //    table: "Admin");

            //migrationBuilder.DropPrimaryKey(
            //    name: "PK_Admin",
            //    table: "Admin");

            //migrationBuilder.RenameTable(
            //    name: "Admin",
            //    newName: "Admins");

            //migrationBuilder.RenameIndex(
            //    name: "IX_Admin_user_type",
            //    table: "Admins",
            //    newName: "IX_Admins_user_type");

            //migrationBuilder.AlterColumn<string>(
            //    name: "email",
            //    table: "Admins",
            //    type: "varchar(100)",
            //    unicode: false,
            //    maxLength: 100,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "varchar(100)",
            //    oldUnicode: false,
            //    oldMaxLength: 100);

            //migrationBuilder.AlterColumn<int>(
            //    name: "admin_id",
            //    table: "Admins",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .Annotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Admins",
            //    table: "Admins",
            //    column: "admin_id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Admins_UserType_user_type",
            //    table: "Admins",
            //    column: "user_type",
            //    principalTable: "UserType",
            //    principalColumn: "user_type_id");
        }
    }
}
