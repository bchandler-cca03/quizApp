using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class StudentQuestionHist
    {
        // the history of an individual question associated with an individual student

        public int QuizId { get; set; }  // QuizId is the Id of the Specific Quiz

        public int StudentId { get; set; }  // StudentId is the Id of the Specific Student

        public int QuestionId { get; set; } // QuestionID is the Id of the Specific Question

        public DateTime EventDate { get; set; }  // date of quiz-question

        public int Result { get; set; }  // use 0 for missed, 1 for partial, 2 for fully correct

    }
}
