using Microsoft.AspNetCore.Mvc;

namespace NC_MVC
{
    //[Route("/")]
    [ApiController]
    [Route("/[controller]")]
    public class AuthorsController : ControllerBase 
    {
        private readonly AuthorService _authorService;
        public AuthorsController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        //[Route("")]
        public IActionResult GetAuthors()
        {
            return Ok(_authorService.GetAuthors());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetIndividualAuthor(int Id)
    {
            Author? author = _authorService.GetAuthor(Id);
            if (author != null)
            {
                return Ok(author);
            }
            else
            {
                return NotFound();
            }
    }


    }
}
