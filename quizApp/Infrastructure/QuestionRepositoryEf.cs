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
            throw new NotImplementedException();
        }

        public Question GetById(int id)
        {
            return new Question();   // TODO:  not sure this is right from other solution
        }

        public List<Question> ListAll()
        {
            // Note:  required the System.Linq to find the "ToList()" function
            return _questionContext.Questions.ToList();
        }

        public void UpdateQuestion(Question updateQuestion)
        {
            throw new NotImplementedException();
        }
    }
}
