using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IStudentQuestionHistRepository
    {
        // List all questions student has completed
        List<StudentQuestionHist> ListAll();

        // List all instances a question has been answered by the student
        List<StudentQuestionHist> GetByStudentId(int id);

        // List all instances of a question being answerd by ANY student
        List<StudentQuestionHist> GetByQuestionId(int id);

        // not sure we need to add a question; we do need to RECORD the result of a question
        void AddStudentQuestionResult(StudentQuestionHist NewStudentQuestionHist);

        // we want to update a specific question record -- not sure it's really used
        void UpdateStudentQuestionResult(StudentQuestionHist UpdateStudentQuestionHist);

        // delete a student-question result
        void Delete(int id);
    }
}
