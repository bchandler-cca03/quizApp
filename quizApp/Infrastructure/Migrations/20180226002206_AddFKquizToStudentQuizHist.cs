using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class AddFKquizToStudentQuizHist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "StudentQuizHist",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quiz", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentQuizHist_QuizId",
                table: "StudentQuizHist",
                column: "QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentQuizHist_Quiz_QuizId",
                table: "StudentQuizHist",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentQuizHist_Quiz_QuizId",
                table: "StudentQuizHist");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropIndex(
                name: "IX_StudentQuizHist_QuizId",
                table: "StudentQuizHist");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "StudentQuizHist");
        }
    }
}
