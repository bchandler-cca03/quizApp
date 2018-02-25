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

        public float Grade { get; set; }

        public DateTime AttemptDateTime { get; set; }

        // Navigation Properties
        // public Student Student { get; set; }
        // public int StudentId { get; set; }  
                                            // StudentId is the Id of the Specific Student
                                            // moved to navigation properites
        // public Quiz Quiz { get; set; }
        // public int QuizId { get; set; }

    }
}
