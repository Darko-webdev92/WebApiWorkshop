using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClass.InterfaceModels.Enums;

namespace WebApiClass.DAL
{
    public interface IRepository<T>
    {
        void Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        List<T> GetByGanre(int ganre);
        //void Delete(T entity);
        //void Update(T entity);
    }
}
