using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace DapperCRUDAPI.Models
{
    public class MovieRepository
    {

        private static string connectionString = @"User ID = sa;Password = YourStrong@Passw0rd;Initial catalog= MovieDatabase;Data Source=localhost,1433;";


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
                string sQuery = @"INSERT INTO MovieModel(MovieID, Title, Genre, Rating, Release, IMDb) VALUES(@ID, @Title, @Genre, @Rating, @Release, @IMDb)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, newMovie);
            }
        }



        public IEnumerable<Movie> MovieViewAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM MovieModel";
                dbConnection.Open();
                return dbConnection.Query<Movie>(sQuery);
            }
        }



        public Movie ViewMovieByID(int ID)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM MovieModel WHERE ID=@Id";
                dbConnection.Open();
                return dbConnection.Query<Movie>(sQuery, new { ID }).FirstOrDefault();
            }

        }

        public void MovieUpdate(Movie newMovie)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"EXEC MovieUpdate @MovieID = @MovieID, @Title = @Title, @Genre = @Genre, @Rating = @Rating, @ReleaseDate = @ReleaseDate, @IMDbScore = @IMDbScore";
                dbConnection.Open();
                dbConnection.Query(sQuery, newMovie);
            }
        }


        public void DeleteMovieByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"EXEC DeleteMovieByID @MovieID=@id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = id });
            }

        }

        public void MovieAdd(Movie newMovie)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"EXEC MovieAdd @MovieID = @MovieID, @Title = @Title, @Genre = @Genre, @Rating = @Rating, @ReleaseDate = @ReleaseDate, @IMDbScore = @IMDbScore";
                dbConnection.Open();
                dbConnection.Execute(sQuery, newMovie);
            }
        }
    }
}