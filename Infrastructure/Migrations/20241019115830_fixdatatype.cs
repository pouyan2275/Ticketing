using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixdatatype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_DataType_TypeId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Tickets",
                newName: "DataTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_TypeId",
                table: "Tickets",
                newName: "IX_Tickets_DataTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_DataType_DataTypeId",
                table: "Tickets",
                column: "DataTypeId",
                principalTable: "DataType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_DataType_DataTypeId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "DataTypeId",
                table: "Tickets",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_DataTypeId",
                table: "Tickets",
                newName: "IX_Tickets_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_DataType_TypeId",
                table: "Tickets",
                column: "TypeId",
                principalTable: "DataType",
                principalColumn: "Id");
        }
    }
}
