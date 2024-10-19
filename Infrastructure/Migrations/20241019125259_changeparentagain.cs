using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeparentagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataType_DataType_DataTypeId",
                table: "DataType");

            migrationBuilder.RenameColumn(
                name: "DataTypeId",
                table: "DataType",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_DataType_DataTypeId",
                table: "DataType",
                newName: "IX_DataType_ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataType_DataType_ParentId",
                table: "DataType",
                column: "ParentId",
                principalTable: "DataType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataType_DataType_ParentId",
                table: "DataType");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "DataType",
                newName: "DataTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_DataType_ParentId",
                table: "DataType",
                newName: "IX_DataType_DataTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataType_DataType_DataTypeId",
                table: "DataType",
                column: "DataTypeId",
                principalTable: "DataType",
                principalColumn: "Id");
        }
    }
}
