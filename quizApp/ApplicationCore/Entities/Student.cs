using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string Email { get; set; }

        public string AspNetUserId { get; set; }

        // Navigation
        // make the below part of migration [1]
        // public StudentQuestionHist StudentQuestionHist { get; set; }
        // public int StudentQuestionHistId { get; set; }

        // make the below part of migration [2]
        // public StudentQuizHist StudentQuizHist { get; set; }
        // public int StudentQuizHistId { get; set; }

    }
}
