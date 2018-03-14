using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Infrastructure
{
    public class QuestionRepositoryEf : IQuestionRepository
    {
        private readonly QuestionContext _questionContext;

        public QuestionRepositoryEf(QuestionContext questionContext)
        {
            _questionContext = questionContext;
        }

        public void AddQuestion(Question newQuestion)
        {
            _questionContext.Add(newQuestion);
            _questionContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var identifiedQuestion = GetById(id);
            _questionContext.Remove(identifiedQuestion);
            _questionContext.SaveChanges();

        }

        public Question GetById(int id)
        {
            var identifiedQuestion = _questionContext.Questions.FirstOrDefault(t => t.Id == id);
            return identifiedQuestion;   // TODO:  not sure this is right from other solution
        }

        public void UpdateQuestion(Question updateQuestion)
        {
            var identifiedQuestion = GetById(updateQuestion.Id);

            identifiedQuestion.Category = updateQuestion.Category;
            identifiedQuestion.SpecificQuestion = updateQuestion.SpecificQuestion;
            identifiedQuestion.SpecificAnswer = updateQuestion.SpecificAnswer;
            _questionContext.SaveChanges();
        }

        public List<Question> ListAll()
        {
            // Note:  required the System.Linq to find the "ToList()" function
            return _questionContext.Questions.ToList();
        }

    }
}
