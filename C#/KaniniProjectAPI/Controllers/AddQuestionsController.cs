using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KaniniProjectAPI.Data;
using KaniniProjectAPI.Models;
using KaniniProjectAPI.Services.AddQuestionServices;

namespace KaniniProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddQuestionsController : ControllerBase
    {
        private readonly IAddQuestionService _context;

        public AddQuestionsController(IAddQuestionService context)
        {
            _context = context;
        }

        // GET: api/AddQuestions
        [HttpGet("GetQuestions")]
        public async Task<ActionResult<IEnumerable<AddQuestion>>> GetQuestions()
        {
            try
            {
                var get = await _context.GetQuestions();
                return Ok(get);
            }
            catch (ArithmeticException ex)
            {
                return NotFound(ex.Message);

            }
        }

     /*   // GET: api/AddQuestions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AddQuestion>> GetAddQuestion(int id)
        {
          if (_context.AddQuestions == null)
          {
              return NotFound();
          }
            var addQuestion = await _context.AddQuestions.FindAsync(id);

            if (addQuestion == null)
            {
                return NotFound();
            }

            return addQuestion;
        }

        // PUT: api/AddQuestions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddQuestion(int id, AddQuestion addQuestion)
        {
            if (id != addQuestion.Id)
            {
                return BadRequest();
            }

            _context.Entry(addQuestion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddQuestionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AddQuestions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AddQuestion>> PostAddQuestion(AddQuestion addQuestion)
        {
          if (_context.AddQuestions == null)
          {
              return Problem("Entity set 'KaniniDbContext.AddQuestions'  is null.");
          }
            _context.AddQuestions.Add(addQuestion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAddQuestion", new { id = addQuestion.Id }, addQuestion);
        }

        // DELETE: api/AddQuestions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddQuestion(int id)
        {
            if (_context.AddQuestions == null)
            {
                return NotFound();
            }
            var addQuestion = await _context.AddQuestions.FindAsync(id);
            if (addQuestion == null)
            {
                return NotFound();
            }

            _context.AddQuestions.Remove(addQuestion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AddQuestionExists(int id)
        {
            return (_context.AddQuestions?.Any(e => e.Id == id)).GetValueOrDefault();
        }*/
    }
}
