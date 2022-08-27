using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClass.DBModels;
using WebApiClass.InterfaceModels;
using WebApiClass.InterfaceModels.Enums;

namespace WebApiClass.Mappers
{
    public static class MovieMapper
    {
        public static Movie ToDbMovieModel(MovieInterfaceModel model)
        {
            return new Movie
            { 
                Id = model.Id,
                Title = model.Title,
                Year = model.Year,
                Description = model.Description,
                Genre = (int)model.Genre
            };
        }
        
        public static MovieInterfaceModel ToMovieInterfaceModel(Movie model)
        {
            return new MovieInterfaceModel
            {
                Id = model.Id,
                Title = model.Title,
                Year = model.Year,
                Description = model.Description,
                Genre = (Genre)model.Genre
            };
        }
    }
}
