using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test.Data;
using test.Models.ViewModels;
using test.Test;

namespace test.Controllers
{
    public class StartController : Controller
    {
        IMovieRepository movieRepository;
        ILikeDislikeRepository likeDislikeRepository;

        public StartController(IMovieRepository movieRepository, ILikeDislikeRepository likeDislikeRepository)
        {
            this.movieRepository = movieRepository;
            this.likeDislikeRepository = likeDislikeRepository;
        }
        public async  Task<IActionResult> Index()
        {
            string imbId = "tt4729430";
            string param = "movie";
            var movie = await movieRepository.GetMoviebyImdbId(imbId);
            var likeDislike = await likeDislikeRepository.GetLikeDislike(param);
            return View(likeDislike);
        }
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Movie()
        {
            //string imbId = "tt4729430";
            string param = "toplist?type=rating&count=10";
            var likeDislikesTop10 = await likeDislikeRepository.GetLikeDislikes(param);
            var top10MoviesId = movieRepository.GetMovieIds(likeDislikesTop10);
            var top10Movies = await movieRepository.GetMoviesByImdbIds(top10MoviesId);

            //var likeDislike = await likeDislikeRepository.GetLikeDislike(imbId);
            var model = new TopMoviesViewModel(top10Movies, likeDislikesTop10[0]);
            return View(model);
        }

        [Route("/start/Movie")]
        [HttpGet("/start/Movie")]
        public async Task<IActionResult> Movie(string imdbID)
        {
            //string imbId = "tt4729430";
            string param = "toplist?type=rating&count=10";
            //var likeDislikesTop10 = await likeDislikeRepository.GetLikeDislikes(imdbID);
            //var top10MoviesId = movieRepository.GetMovieIds(likeDislikesTop10);
           // var top10Movies = await movieRepository.GetMoviesByImdbIds(top10MoviesId);

            //var likeDislike = await likeDislikeRepository.GetLikeDislike(imbId);
            //var model = new TopMoviesViewModel(top10Movies, likeDislikesTop10[0]);
            return View();
        }
    }
}
