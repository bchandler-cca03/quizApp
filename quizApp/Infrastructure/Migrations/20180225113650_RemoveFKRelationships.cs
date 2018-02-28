using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class RemoveFKRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentQuestionHist_StudentQuestionHistId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentQuizHist_StudentQuizHistId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentQuestionHistId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentQuizHistId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentQuestionHistId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentQuizHistId",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentQuestionHistId",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentQuizHistId",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentQuestionHistId",
                table: "Students",
                column: "StudentQuestionHistId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentQuizHistId",
                table: "Students",
                column: "StudentQuizHistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentQuestionHist_StudentQuestionHistId",
                table: "Students",
                column: "StudentQuestionHistId",
                principalTable: "StudentQuestionHist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentQuizHist_StudentQuizHistId",
                table: "Students",
                column: "StudentQuizHistId",
                principalTable: "StudentQuizHist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
