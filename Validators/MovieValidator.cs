using System;
using FluentValidation;
using DapperCRUDAPI.Models;
using Quaranteam_APP.Models;
using System.ComponentModel.DataAnnotations;


namespace Quaranteam_APP.Validators
{
    public class MovieValidator : AbstractValidator<Movie>
    {


        public MovieValidator()
        {
            RuleFor(m => m.MovieID).NotEmpty().GreaterThan(0);

            RuleFor(m => m.Title).NotEmpty().Length(1, 255).WithMessage("Plesae enter Movie Title");

            RuleFor(m => m.Genre).NotEmpty().Length(1, 255).WithMessage("Plesae enter Genre");

            RuleFor(m => m.Rating).NotEmpty().WithMessage("Please enter an age rating");

            RuleFor(m => m.ReleaseDate).NotEmpty().WithMessage("Please enter an age rating");

            RuleFor(m => m.IMDbscore).NotEmpty().WithMessage("Please enter a score");




            Movie movie = new Movie();

            MovieValidator validator = new MovieValidator();

            validator.ValidateAndThrow(movie);

            //ValidationResult results = validator.Validate(movie);

            //object results = null;

            //if (results.Equals)
            //{
            //    foreach (var failure in results.Error)
            //    {
            //        Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
            //    }


                //}

                //private ValidationResult Validate(object movieRepository)
                //{
                //    throw new NotImplementedException();
                //}

                //internal static object Validate(MovieValidator movie)
                //{
                //    throw new NotImplementedException();
                //}
            }
        }
    }
