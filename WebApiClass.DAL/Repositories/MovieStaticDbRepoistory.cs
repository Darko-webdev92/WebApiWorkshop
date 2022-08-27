using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClass.DBModels;
using WebApiClass.InterfaceModels.Enums;

namespace WebApiClass.DAL.Repositories
{
    public class MovieStaticDbRepoistory : IRepository<Movie>
    {
        public void Add(Movie entity)
        {
            entity.Id = ++StaticDb.MovieId;
            StaticDb.Movies.Add(entity);
        }

        public IEnumerable<Movie> GetAll()
        {
            return StaticDb.Movies;
        }

        public Movie GetById(int id)
        {
            var result = StaticDb.Movies.FirstOrDefault(movie => movie.Id == id);
            return result;
        }

        public List<Movie> GetByGanre(int ganre)
        {
            var result = StaticDb.Movies.Where(movie => movie.Genre == ganre).ToList();
            return result;
        }

    }
}
