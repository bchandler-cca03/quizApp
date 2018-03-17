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

        private readonly QuestionContext _studentContext;

        public StudentRepositoryEf(QuestionContext studentContext)
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
            var _identifiedStudent = _studentContext.Students.FirstOrDefault(t => t.Id == id);
            return _identifiedStudent;
        }

        public Student GetByAspNetUserId(String userGuid)
        {
            var _identifiedUser = _studentContext.Students.FirstOrDefault(t => t.AspNetUserId == userGuid);
            if (_identifiedUser == null)
            {
                return _identifiedUser;
            }

            return _identifiedUser;
        }

        public List<Student> ListAll()
        {
            return _studentContext.Students.ToList();
        }

        public void UpdateStudent(Student updateStudent)
        {
            var identifiedStudent = GetById(updateStudent.Id);
            identifiedStudent.FName = updateStudent.FName;
            identifiedStudent.LName = updateStudent.LName;
            identifiedStudent.Email = updateStudent.Email;

            _studentContext.SaveChanges();
        }
    }
}
