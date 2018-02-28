using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace quizApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // GET: Student
        public ActionResult Index()
        {
            return View(_studentRepository.ListAll());
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View(_studentRepository.GetById(id));
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student newStudent, IFormCollection collection)
        {
            if (!ModelState.IsValid)
            {
                return View(newStudent);
            }

            try
            {
                _studentRepository.AddStudent(newStudent);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(newStudent);
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_studentRepository.GetById(id));
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student editedStudent, int id, IFormCollection collection)
        {
            if (!ModelState.IsValid)
            {
                return View(editedStudent);
            }
            try
            {
                _studentRepository.UpdateStudent(editedStudent);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(editedStudent);
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}