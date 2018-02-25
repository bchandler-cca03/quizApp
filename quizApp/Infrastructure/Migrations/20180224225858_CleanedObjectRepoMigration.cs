using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class CleanedObjectRepoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Questions",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InfoLink",
                table: "Questions",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuestionImg",
                table: "Questions",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "Questions",
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

            migrationBuilder.CreateTable(
                name: "StudentQuestionHist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventDate = table.Column<DateTime>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    QuizId = table.Column<int>(nullable: false),
                    Result = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentQuestionHist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentQuizHist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttemptDateTime = table.Column<DateTime>(nullable: false),
                    Grade = table.Column<float>(nullable: false),
                    QuizId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentQuizHist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    FName = table.Column<string>(nullable: true),
                    LName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizId",
                table: "Questions",
                column: "QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Quiz_QuizId",
                table: "Questions",
                column: "QuizId",
                principalTable: "Quiz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Quiz_QuizId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropTable(
                name: "StudentQuestionHist");

            migrationBuilder.DropTable(
                name: "StudentQuizHist");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Questions_QuizId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "InfoLink",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionImg",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Questions",
                nullable: true);
        }
    }
}
