using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class StudentQuestionHist
    {
        // the history of an individual question associated with an individual student

        public int Id { get; set; }

        public DateTime EventDate { get; set; }  // date of quiz-question

        public int Result { get; set; }  // use 0 for missed, 1 for partial, 2 for fully correct

        // Navigation Properties
        // note:  to obtain the students history with a question, we need the student to be
        //   a FK and the Question

       
        public Student Student { get; set; }

        public int StudentId { get; set; }  
                                            // StudentId is the Id of the Specific Student
                                            // moved to navigation properites

        public Question Question { get; set; }
        public int QuestionId { get; set; } 
                                            // QuestionID is the Id of the Specific Question

    }
}
