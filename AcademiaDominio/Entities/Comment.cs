using AcademiaDominio.Common;
using System;

namespace AcademiaDominio.Modelo
{
    public class Comment : BaseEntity<Guid>
    {
        public string Texto { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
