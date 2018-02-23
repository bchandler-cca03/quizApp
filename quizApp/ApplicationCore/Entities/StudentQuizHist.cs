using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class StudentQuizHist
    {
        public int EventId { get; set; }  // individual quiz event

        public DateTime EventDate { get; set; }  // date of quiz-question

        public int Result { get; set; }  // use 0 for missed, 1 for partial, 2 for fully correct

        public int Student { get; set; }  // identify a student by an integer
    }
}
