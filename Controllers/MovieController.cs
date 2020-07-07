using System.Collections.Generic;
using DapperCRUDAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DapperCRUDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MovieController : Controller
    {

        //public IActionResult Index()
        //{
        //    return View();
        //}


        private readonly Models.MovieRepository movieRepository;

        public MovieController()
        {
            movieRepository = new Models.MovieRepository();
        }
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movieRepository.MovieViewAll();
        }


        [HttpGet("{id}")]

        public Movie Get(int id)
        {
            return movieRepository.ViewMovieByID(id);
        }


        [HttpPost]

        public void Post([FromBody] Movie movie)
        {
            if (ModelState.IsValid)
            {
                movieRepository.MovieAdd(movie);
            }
        }

        [HttpPut]

        public void Put([FromBody] Movie newMovie)
        {
            //newMovie.MovieID = id;
            if (ModelState.IsValid)
            {
                movieRepository.MovieUpdate(newMovie);
            }
        }

        [HttpDelete]

        public void Delete(int id)
        {
            movieRepository.DeleteMovieByID(id);
        }







    }
}