using AcademiaDominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDominio.Modelo
{
    public class Comentario : Entidade
    {
        public string Texto { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}
