using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models;
using test.Models.DTO;

namespace test.Data
{
    public interface IMovieRepository
    {
       //void SetEndpoint();
       //string ApiKey { get; set; }
       Task<MovieDto> GetMoviebyImdbId(string imdbid); 
       List<Movie> GetMovieIds(List<LikeDislikeDto> top10lists);
       Task<List<MovieDto>> GetMoviesByImdbIds(List<Movie> movieIds);
    }
}
