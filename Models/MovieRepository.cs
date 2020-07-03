using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace DapperCRUDAPI.Models
{
    public class MovieRepository
    {

        private string connectionString = @"User ID = sa;Password = YourStrong@Passw0rd;Initial catalog= MovieDatabase;Data Source=localhost,1433;";


        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }


        public void Add(Movie newMovie)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"INSERT INTO MovieList(ID, Title, Genre, Rating, Release, IMDb) VALUES(@ID, @Title, @Genre, @Rating, @Release, @IMDb)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, newMovie);
            }
        }



        public IEnumerable<Movie> GetAllMovies()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM MovieList";
                dbConnection.Open();
                return dbConnection.Query<Movie>(sQuery);
            }
        }



        public Movie GetByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM MovieList WHERE ID=@Id";
                dbConnection.Open();
                return dbConnection.Query<Movie>(sQuery, new { Id = id }).FirstOrDefault();
            }

        }

        public Movie GetByRating(int Rating)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM MovieList WHERE Rating=@Rating";
                dbConnection.Open();
                return dbConnection.Query<Movie>(sQuery, new { Rating }).FirstOrDefault();
            }

        }

    }
}