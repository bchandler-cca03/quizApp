using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{

    public class QuestionContext : DbContext
    {
        public QuestionContext(DbContextOptions<QuestionContext> options)
    : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentQuestionHist> StudentQuestionHist { get; set; }

        public DbSet<StudentQuizHist> StudentQuizHist { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(<amphersand goes here>"Server=(localdb)\mssqllocaldb;Database=Cohort03QuizAppEf;Trusted_Connection=True;");
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cohort03QuizAppEf;Trusted_Connection=True;");
        }

    }
}
