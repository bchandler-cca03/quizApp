using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class QuizQuestionRecord
    {
        public int EventId { get; set; }

        public DateTime EventDate { get; set; }

        public int Result { get; set; }  // use 0 for missed, 1 for partial, 2 for fully correct




    }
}
