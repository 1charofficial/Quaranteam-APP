using System;
using FluentValidation;
using DapperCRUDAPI.Models;
using Quaranteam_APP.Models;
using System.ComponentModel.DataAnnotations;


namespace Quaranteam_APP.Validators
{
    public class MovieValidator : AbstractValidator<Movie>
    {


        //public MovieValidator()
        //{
        //    RuleFor(m => m.MovieID).NotEmpty().GreaterThan(0);

        //    MovieValidator validator = new MovieValidator();

        //    ValidationResult results = validator.Validate(Movie);

        //    if(results.Equals == false)
        //    {

        //    }


        //}

        private ValidationResult Validate(object movieRepository)
        {
            throw new NotImplementedException();
        }

        internal static object Validate(MovieValidator movie)
        {
            throw new NotImplementedException();
        }
    }
}
