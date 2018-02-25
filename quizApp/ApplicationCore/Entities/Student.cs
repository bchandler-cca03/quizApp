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


        // Navigation
        public StudentQuestionHist StudentQuestionHist { get; set; }

        public int StudentQuestionHistId { get; set; }

        public StudentQuizHist StudentQuizHist { get; set; }

        public int StudentQuizHistId { get; set; }

    }
}
