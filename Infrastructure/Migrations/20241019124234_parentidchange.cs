using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class parentidchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataType_DataType_ParentId",
                table: "DataType");

            migrationBuilder.DropIndex(
                name: "IX_DataType_ParentId",
                table: "DataType");

            migrationBuilder.AddColumn<Guid>(
                name: "DataTypeId",
                table: "DataType",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataType_DataTypeId",
                table: "DataType",
                column: "DataTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataType_DataType_DataTypeId",
                table: "DataType",
                column: "DataTypeId",
                principalTable: "DataType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataType_DataType_DataTypeId",
                table: "DataType");

            migrationBuilder.DropIndex(
                name: "IX_DataType_DataTypeId",
                table: "DataType");

            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "DataType");

            migrationBuilder.CreateIndex(
                name: "IX_DataType_ParentId",
                table: "DataType",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataType_DataType_ParentId",
                table: "DataType",
                column: "ParentId",
                principalTable: "DataType",
                principalColumn: "Id");
        }
    }
}
