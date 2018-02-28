using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Quiz
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        List<Question> QuizQuestionSet = new List<Question>();

        // Navigation Properties
        // Make the below part of a separate migration [3]
        // public StudentQuizHist StudentQuizHist { get; set; }

        // public int StudentQuizHistId { get; set; }

    }
}
