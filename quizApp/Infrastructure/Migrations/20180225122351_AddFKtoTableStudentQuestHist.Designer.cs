﻿// <auto-generated />
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(QuestionContext))]
    [Migration("20180225122351_AddFKtoTableStudentQuestHist")]
    partial class AddFKtoTableStudentQuestHist
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationCore.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category")
                        .HasMaxLength(25);

                    b.Property<string>("InfoLink")
                        .HasMaxLength(255);

                    b.Property<string>("QuestionImg")
                        .HasMaxLength(255);

                    b.Property<string>("specificAnswer");

                    b.Property<string>("specificQuestion");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FName");

                    b.Property<string>("LName");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ApplicationCore.Entities.StudentQuestionHist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EventDate");

                    b.Property<int>("Result");

                    b.Property<int>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentQuestionHist");
                });

            modelBuilder.Entity("ApplicationCore.Entities.StudentQuizHist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AttemptDateTime");

                    b.Property<float>("Grade");

                    b.HasKey("Id");

                    b.ToTable("StudentQuizHist");
                });

            modelBuilder.Entity("ApplicationCore.Entities.StudentQuestionHist", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
