using System;
using System.Collections.Generic;
using AcademiaDominio.Entities;
using AcademiaDominio.Interfaces;
using AcademiaDominio.Modelo;

namespace AcademiaDominio.Repositories
{
    class DirectorCRUD : ICRUD<Director, int>
    {
        public Director Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Movie GetAll()
        {
            throw new NotImplementedException();
        }

        public Director GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Director Insert(Director item)
        {
            throw new NotImplementedException();
        }

        public Director Update(Director item)
        {
            throw new NotImplementedException();
        }

        IList<Director> ICRUD<Director, int>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
