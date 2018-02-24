using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class StudentQuizHistRepositoryEf : IStudentQuizHistRepository
    {
        private readonly StudentQuizHistContext _studentQuizHistContext;

        public StudentQuizHistRepositoryEf(StudentQuizHistContext studentQuizHistContext)
        {
            _studentQuizHistContext = studentQuizHistContext;
        }

        public void AddStudentQuizHist(StudentQuizHist newHist)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudentQuizHist(int id)
        {
            throw new NotImplementedException();
        }

        public StudentQuizHist GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<StudentQuizHist> ListAll()
        {
            return _studentQuizHistContext.StudentQuizHist.ToList();
        }

        public List<StudentQuizHist> ListAllByStudentId(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudentQuizHist(StudentQuizHist updateHist)
        {
            throw new NotImplementedException();
        }

    }
}
