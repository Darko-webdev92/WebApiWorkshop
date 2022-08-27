using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiClass.InterfaceModels;
using WebApiClass.Services.Interfaces;

namespace WebAPIClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllMovies()
        {
            var response = _movieService.GetAll();
            return Ok(response);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetMovieById([FromRoute] int id)
        {
            var response = _movieService.GetById(id);
            return Ok(response);
        }

        [HttpGet("GetByGanre/{genre}")]
        public IActionResult GetMoviesByGenre([FromRoute] int genre)
        {
            var response = _movieService.GetByGanre(genre);
            return Ok(response);
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] MovieInterfaceModel model)
        {
            _movieService.Create(model);
            return Ok();
        }
    }
}
