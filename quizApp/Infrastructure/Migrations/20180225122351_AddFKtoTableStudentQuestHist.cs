using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class AddFKtoTableStudentQuestHist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudentQuestionHist",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentQuestionHist_StudentId",
                table: "StudentQuestionHist",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentQuestionHist_Students_StudentId",
                table: "StudentQuestionHist",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentQuestionHist_Students_StudentId",
                table: "StudentQuestionHist");

            migrationBuilder.DropIndex(
                name: "IX_StudentQuestionHist_StudentId",
                table: "StudentQuestionHist");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudentQuestionHist");
        }
    }
}
