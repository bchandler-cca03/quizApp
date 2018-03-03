using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace quizApp.Controllers
{
    [Produces("application/json")]
    [Route("api/QuesGame")]
    public class QuesGameController : Controller
    {
        private readonly IQuestionRepository _context;

        public QuesGameController(IQuestionRepository context)
        {
            _context = context;

        }

        // GET: api/QuesGame
        [HttpGet]
        public IEnumerable<Question> Get()
        {
            return _context.ListAll();

        }
        // GET: api/QuesGame/5
        // "GetQuestion" below is a 'route-name'
        [HttpGet("{id}", Name = "GetQuestion")]
        public IActionResult Get(int id)
        {
            var question = _context.GetById(id);
            return new ObjectResult(question);
        }
        // POST: api/QuesGame
        [HttpPost]
        public IActionResult Create([FromBody]Question newQuestion)
        {
            if(newQuestion == null)
            {
                return BadRequest();
            }
            _context.AddQuestion(newQuestion);

            return CreatedAtRoute("GetQuestion", new { id = newQuestion.Id }, newQuestion);
        }
        // PUT: api/QuesGame/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]Question updateQuestion)
        {
            if(updateQuestion == null || updateQuestion.Id != id)
            {
                return BadRequest();
            }
            var pulledQuestion = _context.GetById(id);

            if(pulledQuestion == null)
            {
                return NotFound();
            }
            pulledQuestion.Category = updateQuestion.Category;
            pulledQuestion.QuestionImg = updateQuestion.QuestionImg;
            pulledQuestion.specificQuestion = updateQuestion.specificQuestion;
            pulledQuestion.specificAnswer = updateQuestion.specificAnswer;
            pulledQuestion.InfoLink = updateQuestion.InfoLink;

            _context.UpdateQuestion(pulledQuestion);

            return new NoContentResult();

    }
        // DELETE: api/QuesGame/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var question = _context.GetById(id);

            if (question == null)
            {
                return NotFound();
            }
            _context.Delete(question.Id);

            return new NoContentResult();
        }
    }
}
