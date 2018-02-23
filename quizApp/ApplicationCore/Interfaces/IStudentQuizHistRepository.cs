using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IStudentQuizHistRepository
    {
        List<StudentQuizHist> ListAll();

        List<StudentQuizHist> ListAllByStudentId(int id);

        StudentQuizHist GetById(int id);

        void AddStudentQuizHist(StudentQuizHist newHist);

        void UpdateStudentQuizHist(StudentQuizHist updateHist);

        void DeleteStudentQuizHist(int id);

    }
}
