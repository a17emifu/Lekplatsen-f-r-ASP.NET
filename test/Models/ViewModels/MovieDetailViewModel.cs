using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models.DTO;

namespace test.Models.ViewModels
{
    public class MovieDetailViewModel
    {
        public MovieDto Movie { get; set; }
        public LikeDislikeDto LikeDislike { get; set; }

        public MovieDetailViewModel(MovieDto selectedMovie, LikeDislikeDto likeDislike)
        {
            Movie = selectedMovie;
            LikeDislike = likeDislike;
        }
    }
}
