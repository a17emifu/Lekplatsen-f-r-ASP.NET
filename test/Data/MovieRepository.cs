using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using test.Models;
using test.Models.DTO;
using test.Test;

namespace test.Data
{
    public class MovieRepository: BaseRepository, IMovieRepository
    {
      
        public string ApiKey { get; set; }
        List<Movie> movieTitles;

        public MovieRepository(IConfiguration configuration)
        {

            baseUrl = configuration.GetValue<string>("OMDbApi:BaseUrl");
            ApiKey = configuration.GetValue<string>("OMDbApi:Key");
            

        }

        public Task<MovieDto> GetMoviebyImdbId(string imdbid)
        {
            string endPoint = $"{baseUrl}?i={imdbid}&apikey={ApiKey}";
            var movie = GetData<MovieDto>(endPoint);
            return movie;

        }


        public List<Movie> GetMovieIds(List<LikeDislikeDto> top10lists)
        {
            var movies = TakeImdbIds(top10lists);
            return movies;
        }

        private List<Movie> TakeImdbIds(List<LikeDislikeDto> top10lists)
        {
            movieTitles = new List<Movie>();
            
            foreach(var movieTitle in top10lists)
            {
                Movie movie = new Movie
                {
                    imdbID = movieTitle.imdbID
                };
                movieTitles.Add(movie);
            }
            return movieTitles;
            
        }

        public async Task<List<MovieDto>> GetMoviesByImdbIds(List<Movie> movieIds)
        {
            List<MovieDto> movies = new List<MovieDto>();
            foreach (var movieId in movieIds)
            {
                var movie = await GetMoviebyImdbId(movieId.imdbID);
                movies.Add(movie);
            }

            return movies;
        }
    }
}
