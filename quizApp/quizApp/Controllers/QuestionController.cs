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
    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        // GET: Question
        public ActionResult Index()
        {
            // var foo = _questionRepository.NextDueQuestions(1);
            return View(_questionRepository.ListAll());
        }

        // GET: Question/Details/5
        public ActionResult Details(int id)
        {
            return View(_questionRepository.GetById(id));
        }

        // GET: Question/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Question/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Question newQuestion, IFormCollection collection)
        {

            if(!ModelState.IsValid)
            {
                return View(newQuestion);
            }
            try
            {
                _questionRepository.AddQuestion(newQuestion);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Question/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_questionRepository.GetById(id));
        }

        // POST: Question/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Question updateQuestion, int id, IFormCollection collection)
        {
            if(!ModelState.IsValid)
            {
                return View(updateQuestion);
            }
            try
            {
                _questionRepository.UpdateQuestion(updateQuestion);
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Question/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_questionRepository.GetById(id));
        }

        // POST: Question/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                    _questionRepository.Delete(id);

                    return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}