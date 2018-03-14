using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class StudentQuestionHistRepositoryEf : IStudentQuestionHistRepository
    {
        private readonly QuestionContext _studentQuestionHistContext;

        public StudentQuestionHistRepositoryEf(QuestionContext studentQuestionHistContext)
        {
            _studentQuestionHistContext = studentQuestionHistContext;
        }

        public void AddStudentQuestionResult(StudentQuestionHist NewStudentQuestionHist)
        {
            _studentQuestionHistContext.Add(NewStudentQuestionHist);
            _studentQuestionHistContext.SaveChanges();
        }
        
        // this should be a list of all question events associated with a specific student
        public List<StudentQuestionHist> GetByStudentId(int id)
        {
            List<StudentQuestionHist> studentQuestionEventList = _studentQuestionHistContext
                .StudentQuestionHist
                .Where(t => t.StudentId == id)
                .ToList();
            return studentQuestionEventList;
        }

        public List<StudentQuestionHist> GetByQuestionId(int id)
        {
            List<StudentQuestionHist> questionHistory = _studentQuestionHistContext
                .StudentQuestionHist
                .Where(t => t.QuestionId == id)
                .ToList();   // could return here with no variable assignment, but this allows debugging
            return questionHistory;
        }

        public List<StudentQuestionHist> ListAll()
        {
            return _studentQuestionHistContext.StudentQuestionHist.ToList<StudentQuestionHist>();
        }

        public void UpdateStudentQuestionResult(StudentQuestionHist UpdateStudentQuestionHist)
        {
            throw new NotImplementedException();  // no, you cannot change your grade from here!
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
