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

        [StringLength(255)]
        public string SpecificQuestion { get; set; }  // dot net convention, capitalize

        [StringLength(255)]
        public string SpecificAnswer { get; set; }

        [StringLength(255)]
        public string InfoLink { get; set; }
      
        public List<StudentQuestionHist> StudentQuestionHists { get; set; }
    }
}
