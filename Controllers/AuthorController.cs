using Microsoft.AspNetCore.Mvc;
using TestingEfCoreOne.Context;
using TestingEfCoreOne.Model;

namespace TestingEfCoreOne.Controllers
{
	public class AuthorController : Controller
	{
		private readonly ApplicationContext _context;
        public AuthorController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpPost("Register Author")]
        public IActionResult CreateAuthor(Author author)
        {
            _context.Author.Add(author);
            _context.SaveChanges();
            return Ok(author);
        }

        [HttpGet("GetAuthorById")]
        public IActionResult GetAuthorById(int  id)
        {
            var getUser = _context.Author.Find(id);
            if(getUser == null)
            {
                return BadRequest();
            }
            return Ok(getUser);
        }

        [HttpGet("GetAuthors")]
        public IActionResult GetAllAuthors()
        {
            var getAuthors = _context.Author.ToList();
            return Ok(getAuthors);
        }

        [HttpPut("UpdateAuthor")]
        public IActionResult UpdateAuthor(Author author)
        {
            _context.Author.Update(author);
            _context.SaveChanges();
            return Ok(author);
        }

        [HttpDelete("Delete Author")]
        public IActionResult DeleteAuthor(Author author)
        {
            _context.Author.Remove(author);
            _context.SaveChanges();
            return Ok("Author Remove Successfuly");
         }
    }
}
