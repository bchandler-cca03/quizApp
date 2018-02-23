using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class StudentQuizHistContext : DbContext
    {
        public StudentQuizHistContext(DbContextOptions<StudentQuizHistContext> options)
: base(options)
        {

        }

        public DbSet<StudentQuizHist> StudentQuizHist { get; set; }

    }
}
