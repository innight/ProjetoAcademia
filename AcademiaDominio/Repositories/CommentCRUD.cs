using System;
using System.Collections.Generic;
using System.Linq;
using AcademiaDominio.Interfaces;
using AcademiaDominio.Modelo;

namespace AcademiaDominio.Repositories
{
    class CommentCrud : ICRUD<Comment, Guid>
    {
        private readonly IList<Comment> _comments = new List<Comment>();

        public Comment Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public Comment Insert(Comment item)
        {
            // Utilização Lambda
            var pesquisa = _comments.First(p => p.Id == item.Id);
            if (pesquisa == null)
            {
                _comments.Add(item);
            }
            return pesquisa;
        }

        public Comment Update(Comment item)
        {
            throw new NotImplementedException();
        }
    }
}
