using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class AddFKstudentToTableStudentQuizHist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudentQuizHist",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentQuizHist_StudentId",
                table: "StudentQuizHist",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentQuizHist_Students_StudentId",
                table: "StudentQuizHist",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentQuizHist_Students_StudentId",
                table: "StudentQuizHist");

            migrationBuilder.DropIndex(
                name: "IX_StudentQuizHist_StudentId",
                table: "StudentQuizHist");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudentQuizHist");
        }
    }
}
