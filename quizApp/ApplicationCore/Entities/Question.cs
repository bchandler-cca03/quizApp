using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Question
    {
        public int Id { get; set; }

        [StringLength(25)]  // result will be nvarchar(25) in EntityFramework
        public string Category { get; set; }

        [StringLength(255)]
        public string QuestionImg { get; set; }

        public string specificQuestion { get; set; }  // dot net convention, capitalize

        public string specificAnswer { get; set; }

        [StringLength(255)]
        public string InfoLink { get; set; }

        // Navigation Properties

        public Quiz Quiz { get; set; }

        public int QuizId { get; set; }

        public StudentQuestionHist StudentQuestionHist { get; set; } 

        public int StudentQuestionHistId { get; set; }
        
    }
}
