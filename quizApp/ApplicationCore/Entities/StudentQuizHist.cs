using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class StudentQuizHist
    {
        // will keep summary information in QuizAttempt
        // will retain specific self-graded answer results in StudentQuestionHist
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int QuizId { get; set; }

        public float Grade { get; set; }

        public int AttemptDateTime { get; set; }

    }
}
