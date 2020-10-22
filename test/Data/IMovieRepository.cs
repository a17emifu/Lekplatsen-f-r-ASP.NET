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

       Task<MovieDto> GetMoviebyImdbId(string imdbid); 
       List<Movie> GetMovieIds(List<LikeDislikeDto> top10lists);
       Task<List<MovieDto>> GetMoviesByImdbIds(List<Movie> movieIds);

       //TO DO: SearchMoviesByKeyWord (string word);         FÖR SÖKFUNKTION
       //TO DO: SearchMoviesByType (string type);            FÖR SÖKFUNKTION
       //TO DO: GetMovieFullPlot (string imdbid);            FÖR ATT VISA FULL PLOT
    }
}
