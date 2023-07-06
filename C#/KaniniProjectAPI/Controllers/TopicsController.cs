using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KaniniProjectAPI.Data;
using KaniniProjectAPI.Models;
using KaniniProjectAPI.Services.Topic_Services;

namespace KaniniProjectAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicService _context;

        public TopicsController(ITopicService context)
        {
            _context = context;
        }

        // GET: api/Topics
        [HttpGet("AvailableTopics")]
        public async Task<ActionResult<List<AvailableTopics>>> AvailableTopics()
        {
            try {
                var available =await  _context.AvailableTopics();
                return Ok(available);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpGet("GetTopic")]
        public async Task<ActionResult<List<Topic>>> GetTopics()
        {
            try
            {
                var available = await _context.GetTopics();
                return Ok(available);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        /*    // GET: api/Topics/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Topic>> GetTopic(int id)
            {
              if (_context.Topics == null)
              {
                  return NotFound();
              }
                var topic = await _context.Topics.FindAsync(id);

                if (topic == null)
                {
                    return NotFound();
                }

                return topic;
            }

            // PUT: api/Topics/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id}")]
            public async Task<IActionResult> PutTopic(int id, Topic topic)
            {
                if (id != topic.Id)
                {
                    return BadRequest();
                }

                _context.Entry(topic).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TopicExists(id))
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

            // POST: api/Topics
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
            public async Task<ActionResult<Topic>> PostTopic(Topic topic)
            {
              if (_context.Topics == null)
              {
                  return Problem("Entity set 'KaniniDbContext.Topics'  is null.");
              }
                _context.Topics.Add(topic);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetTopic", new { id = topic.Id }, topic);
            }

            // DELETE: api/Topics/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteTopic(int id)
            {
                if (_context.Topics == null)
                {
                    return NotFound();
                }
                var topic = await _context.Topics.FindAsync(id);
                if (topic == null)
                {
                    return NotFound();
                }

                _context.Topics.Remove(topic);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool TopicExists(int id)
            {
                return (_context.Topics?.Any(e => e.Id == id)).GetValueOrDefault();
            }*/
    }
}
