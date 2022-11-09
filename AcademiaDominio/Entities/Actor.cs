using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaDominio.Common;
using AcademiaDominio.Contratos;

namespace AcademiaDominio.Modelo
{
    public class Actor : Person
    {
        public Actor()
        {
            this.Id = 0;
        }
        /// <summary>
        /// Papel desempenhado no filme
        /// </summary>

        public string Description { get; set; }

        public string Name { get; set; }
        /// <summary>
        /// 1 Actor pode estar em varios filmes
        /// </summary>
        public IList<Movie> Movies { get; set; }
    }
}
