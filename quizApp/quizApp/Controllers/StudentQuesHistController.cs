using System;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace quizApp.Controllers
{
    [Produces("application/json")]
    [Route("api/StudentQuesHist")]   
    public class StudentQuesHistController : Controller
    {
        private readonly IStudentQuestionHistRepository _repo;

        public StudentQuesHistController(IStudentQuestionHistRepository repo)
        {
            _repo = repo;
        }
        // this will get all of the 
        // GET: api/StudentQuesHist
        [HttpGet]
        public IEnumerable<StudentQuestionHist> Get()   
              // note, I am returning a list of StudentQuestionHist entities
        {
            Console.WriteLine("In Get() of StudentQuestionHist");
            return _repo.ListAll();
        }

        // GET: api/StudentQuesHist/5
        [HttpGet("{id}", Name = "GetStudentQuestionHistory")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/StudentQuesHist
        // this is the create for a new record
        [HttpPost]
        public IActionResult Create ([FromBody] StudentQuestionHist newStudentQuesResult)
        {
            if(newStudentQuesResult == null)
            {
                return BadRequest();
            }
            newStudentQuesResult.EventDate = DateTime.Now;
            _repo.AddStudentQuestionResult(newStudentQuesResult);

            // borrowed return CreatedAtRoute("GetQuestion", new { id = newQuestion.Id }, newQuestion);
            return CreatedAtRoute("GetStudentQuestionHistory", new { id = newStudentQuesResult.Id }, newStudentQuesResult);
        }
        
        // PUT: api/StudentQuesHist/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
