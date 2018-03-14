using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using quizApp.Models;

namespace quizApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuestionRepository _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IStudentRepository _student;


        public HomeController(IQuestionRepository context,
            UserManager<ApplicationUser> userManager,
            IStudentRepository student)
        {
            _context = context;
            _userManager = userManager;
            _student = student;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Authorize]
        public IActionResult PlayGame()
        {

            var studentProfile = _student.GetByAspNetUserId(_userManager.GetUserId(HttpContext.User));

            return View(studentProfile);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
