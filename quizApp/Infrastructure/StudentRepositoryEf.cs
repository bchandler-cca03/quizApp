using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure
{
    public class StudentRepositoryEf : IStudentRepository
    {

        private readonly StudentContext _studentContext;

        public StudentRepositoryEf()
        {

        }

        public StudentRepositoryEf(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        public void AddStudent(Student newStudent)
        {
            _studentContext.Add(newStudent);
            _studentContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> ListAll()
        {
            return _studentContext.Students.ToList();
        }

        public void UpdateStudent(Student updateStudent)
        {
            throw new NotImplementedException();
        }
    }
}
