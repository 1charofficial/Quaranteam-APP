using System;
using System.Collections.Generic;
using System.Net;
using DapperCRUDAPI.Models;
using Quaranteam_APP;

namespace MovieRepository.Service
{
    public class ServiceRepository : IMovieRepository
    {
        public WebClient client = new WebClient();
        public string ConnectionString = "User ID = sa; Password = YourStrong@Passw0rd; Initial catalog = MovieDatabase; Data Source = localhost,1433;";



        //public <IEnumerableIMovie> MovieViewAll()
        //{
        //string result = client.DownloadString(ConnectionString);
        //IEnumerable<Movie> movies = JsonConvert.DeserializeObject<IEnumerable<Movie>>(result);
        //return movies;

        //    throw new NotImplementedException();
        //}

        IEnumerable<Movie> MovieViewAll()
        {
            throw new NotImplementedException();
        }


        public void AddMovie(Movie newMovie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovieByID(int MovieID)
        {
            throw new NotImplementedException();
        }

        public void MovieUpdate(int MovieID, string Title, string Genre, string Rating, DateTime ReleaseDate, decimal IMDb)
        {
            throw new NotImplementedException();
        }

        
        public Movie ViewMovieByID(int MovieID)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Movie> IMovieRepository.MovieViewAll()
        {
            throw new NotImplementedException();
        }
    }



}

