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
        // public DbSet<Post> Posts { get; set; }

        // Todo:  why did adding using Microsoft.EntityFrameWorkCore solve Jeff's squigglies but not mine
        // see day class video at 42:47
        // ZZZ - reset 50:49
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(<amphersand goes here>"Server=(localdb)\mssqllocaldb;Database=Cohort03QuizAppEf;Trusted_Connection=True;");
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cohort03QuizAppEf;Trusted_Connection=True;");
        }
    }
}
