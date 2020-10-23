using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models.DTO;

namespace test.Models.ViewModels
{
    public class TopMoviesViewModel
    {
        public List<MovieDto> Movies { get; set; }
        public LikeDislikeDto LikeDislikeDto { get; set; }

        public TopMoviesViewModel() { }

        public TopMoviesViewModel(List<MovieDto> movies, LikeDislikeDto likeDislike)
        {
            Movies = movies;
            LikeDislikeDto = likeDislike;
        }
    }
}
