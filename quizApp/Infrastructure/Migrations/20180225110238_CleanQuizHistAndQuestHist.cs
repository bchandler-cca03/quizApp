using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class CleanQuizHistAndQuestHist : Migration
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

            migrationBuilder.CreateTable(
                name: "StudentQuestionHist",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventDate = table.Column<DateTime>(nullable: false),
                    Result = table.Column<int>(nullable: false)
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
                    Grade = table.Column<float>(nullable: false)
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
                    LName = table.Column<string>(nullable: true),
                    StudentQuestionHistId = table.Column<int>(nullable: false),
                    StudentQuizHistId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_StudentQuestionHist_StudentQuestionHistId",
                        column: x => x.StudentQuestionHistId,
                        principalTable: "StudentQuestionHist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_StudentQuizHist_StudentQuizHistId",
                        column: x => x.StudentQuizHistId,
                        principalTable: "StudentQuizHist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentQuestionHistId",
                table: "Students",
                column: "StudentQuestionHistId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentQuizHistId",
                table: "Students",
                column: "StudentQuizHistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "StudentQuestionHist");

            migrationBuilder.DropTable(
                name: "StudentQuizHist");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "InfoLink",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "QuestionImg",
                table: "Questions");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Questions",
                nullable: true);
        }
    }
}
