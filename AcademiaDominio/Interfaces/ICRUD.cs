using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaDominio.Modelo;

namespace AcademiaDominio.Interfaces
{
    /// <summary>
    /// T - Type
    /// K - Value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    public interface ICRUD<T, K>
    {
        /*
         Interface para cada class
        */
        //Movie GetMovie(int id);
        //Movie Insert(Movie movie);
        //Movie Update(Movie movie);
        //Movie Delete(int id);
        //Movie GetAll();
        T GetOne(K id);
        T Insert(T item);
        T Update(T item);
        T Delete(K id);
        IList<T> GetAll();

    }
}
