using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> ListAll();

        Student GetById(int id);

        Student GetByAspNetUserId(string guid);

        void AddStudent(Student newStudent);

        void UpdateStudent(Student updateStudent);

        void Delete(int id);
    }
}
