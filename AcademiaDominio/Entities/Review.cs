using AcademiaDominio.Common;

namespace AcademiaDominio.Modelo
{
    public class Review: BaseEntity<int>
    {
        public string ReviewText { get; set; }
        public int Stars { get; set; }
        public Movie Movie { get; set; }
    }
}