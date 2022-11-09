using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDominio.Common
{
    /// <summary>
    /// K representa a KEy
    /// </summary>
    /// <typeparam name="k"></typeparam>
    public abstract class BaseEntity<k>
    {
        public k Id { get; set; }
    }
}
