using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
: base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(<amphersand goes here>"Server=(localdb)\mssqllocaldb;Database=Cohort03QuizAppEf;Trusted_Connection=True;");
            // optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cohort03QuizAppEf;Trusted_Connection=True;");
        }

    }
}
