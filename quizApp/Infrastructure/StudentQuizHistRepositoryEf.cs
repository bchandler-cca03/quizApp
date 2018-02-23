using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class StudentQuizHistRepositoryEf : IStudentQuestionHistRepository
    {
        private readonly StudentQuizHistContext _studentQuizHistContext;

        public StudentQuizHistRepositoryEf(StudentQuizHistContext studentQuizHistContext)
        {
            _studentQuizHistContext = studentQuizHistContext;
        }

        public void AddStudentQuizHist(StudentQuizHist newHist)
        {

        }

        public void UpdateStudentQuizHist(StudentQuizHist updateHist)
        {

        }

        public void GetById(int id)  // this will get 1-quiz history element
        {

        }

        public List<StudentQuizHist> ListAll()
        {
            return _studentQuizHistContext.StudentQuizHist.ToList();
        }

        public List<StudentQuizHist> ListAllByStudentId(int id)
        {
            
        }

    }
}
