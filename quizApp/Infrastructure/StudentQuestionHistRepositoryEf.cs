using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class StudentQuestionHistRepositoryEf : IStudentQuestionHistRepository
    {
        private readonly StudentQuestionHist _studentQuestionHistContext;

        public StudentQuestionHistRepositoryEf(StudentQuestionHist studentQuestionHistContext)
        {
            _studentQuestionHistContext = studentQuestionHistContext;
        }

        public void AddQuestion(ApplicationCore.Entities.StudentQuestionHist NewStudentQuestionHist)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public StudentQuestionHist GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationCore.Entities.StudentQuestionHist> ListAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateQuestion(ApplicationCore.Entities.StudentQuestionHist UpdateStudentQuestionHist)
        {
            throw new NotImplementedException();
        }
    }
}
