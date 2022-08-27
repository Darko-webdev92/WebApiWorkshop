using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClass.DAL;
using WebApiClass.DBModels;
using WebApiClass.InterfaceModels;
using WebApiClass.Mappers;
using WebApiClass.Services.Interfaces;

namespace WebApiClass.Services
{
    public class MovieService: IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;
        public MovieService(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void Create(MovieInterfaceModel model)
        {
            _movieRepository.Add(MovieMapper.ToDbMovieModel(model));

        }

        public List<MovieInterfaceModel> GetAll()
        {
            return _movieRepository.GetAll().Select(movie => MovieMapper.ToMovieInterfaceModel(movie)).ToList();
        }

        public List<MovieInterfaceModel> GetByGanre(int ganre)
        {
            return _movieRepository.GetAll().
                                    Where(movie => movie.Genre == ganre).
                                    Select(movie => MovieMapper.ToMovieInterfaceModel(movie)).ToList();
        }

        public MovieInterfaceModel GetById(int id)
        {
            return MovieMapper.ToMovieInterfaceModel(_movieRepository.GetById(id));
        }
    }
}
