using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class AddFKquestionToTableStudentQuestHist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "StudentQuestionHist",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentQuestionHist_QuestionId",
                table: "StudentQuestionHist",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentQuestionHist_Questions_QuestionId",
                table: "StudentQuestionHist",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentQuestionHist_Questions_QuestionId",
                table: "StudentQuestionHist");

            migrationBuilder.DropIndex(
                name: "IX_StudentQuestionHist_QuestionId",
                table: "StudentQuestionHist");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "StudentQuestionHist");
        }
    }
}
