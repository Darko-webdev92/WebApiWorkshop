using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClass.InterfaceModels;

namespace WebApiClass.Services.Interfaces
{
    public interface IMovieService
    {
        List<MovieInterfaceModel> GetAll();
        MovieInterfaceModel GetById(int id);
        List<MovieInterfaceModel> GetByGanre(int ganre);
        void Create(MovieInterfaceModel model);

    }
}
