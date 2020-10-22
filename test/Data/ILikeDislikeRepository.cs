using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Models.DTO;

namespace test.Data
{
    public interface ILikeDislikeRepository
    {

        Task<LikeDislikeDto> GetLikeDislike(string param);
        Task<List<LikeDislikeDto>> GetLikeDislikes(string param);

        //TO DO: PostLike(string param);    FÖR GILLA_KNAPP
        //TO DO: PostDislike(string param);     FÖR OGILLA KNAPP
    }
}
