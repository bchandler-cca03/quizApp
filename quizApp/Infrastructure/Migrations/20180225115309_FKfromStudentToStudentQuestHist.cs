using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class FKfromStudentToStudentQuestHist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentQuestionHistId",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentQuestionHistId",
                table: "Students",
                column: "StudentQuestionHistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentQuestionHist_StudentQuestionHistId",
                table: "Students",
                column: "StudentQuestionHistId",
                principalTable: "StudentQuestionHist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentQuestionHist_StudentQuestionHistId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentQuestionHistId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentQuestionHistId",
                table: "Students");
        }
    }
}
