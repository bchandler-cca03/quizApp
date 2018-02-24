using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class StudentQuestionHistRepositoryEf : IStudentQuestionHistRepository
    {
        private readonly StudentQuestionHistContext _studentQuestionHistContext;

        public StudentQuestionHistRepositoryEf(StudentQuestionHistContext studentQuestionHistContext)
        {
            _studentQuestionHistContext = studentQuestionHistContext;
        }

        public void AddQuestion(StudentQuestionHist NewStudentQuestionHist)
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

        public List<StudentQuestionHist> ListAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateQuestion(StudentQuestionHist UpdateStudentQuestionHist)
        {
            throw new NotImplementedException();
        }
    }
}
