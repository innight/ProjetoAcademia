using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaDominio.Interfaces;
using AcademiaDominio.Modelo;

namespace AcademiaDominio.Repositories
{
    public class ActorCRUD : ICRUD<Actor, int>
    {
        private readonly IList<Actor> _actores = new List<Actor>();
        public Actor Delete(int id)
        {
            _actores.RemoveAt(id);
            return null;
        }

        public Movie GetAll()
        {
            throw new NotImplementedException();
        }

        public Actor GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Insert(Actor item)
        {
            // Utilização Lambda
            var pesquisa = _actores.First(p => p.Id == item.Id);
            if (pesquisa == null)
            {
                _actores.Add(item);
            }
            return pesquisa;
        }

        public Actor Update(Actor item)
        {
            throw new NotImplementedException();
        }

        IList<Actor> ICRUD<Actor, int>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
