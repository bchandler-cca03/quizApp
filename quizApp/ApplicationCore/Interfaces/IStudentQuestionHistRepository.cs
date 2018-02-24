using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IStudentQuestionHistRepository
    {
        List<StudentQuestionHist> ListAll();

        StudentQuestionHist GetById(int id);

        void AddQuestion(StudentQuestionHist NewStudentQuestionHist);

        void UpdateQuestion(StudentQuestionHist UpdateStudentQuestionHist);

        void Delete(int id);
    }
}
