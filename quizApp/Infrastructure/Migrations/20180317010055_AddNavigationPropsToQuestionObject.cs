using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class AddNavigationPropsToQuestionObject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "specificQuestion",
                table: "Questions",
                newName: "SpecificQuestion");

            migrationBuilder.RenameColumn(
                name: "specificAnswer",
                table: "Questions",
                newName: "SpecificAnswer");

            migrationBuilder.AlterColumn<string>(
                name: "SpecificQuestion",
                table: "Questions",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecificAnswer",
                table: "Questions",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SpecificQuestion",
                table: "Questions",
                newName: "specificQuestion");

            migrationBuilder.RenameColumn(
                name: "SpecificAnswer",
                table: "Questions",
                newName: "specificAnswer");

            migrationBuilder.AlterColumn<string>(
                name: "specificQuestion",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "specificAnswer",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
