using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaDominio.Contratos;
using AcademiaDominio.Enumerations;

namespace AcademiaDominio.Modelo
{
    /// <summary>
    /// Representa todos os filmes no nosso dominio
    /// </summary>
    public class Movie : Entidade
    {
        /// <summary>
        /// Repository IReposotyr
        /// Genericos? Criar Inser, update,delete
        /// </summary>
        public Movie()
        {
            Actores = new List<Actor>();
            Comments = new List<Comment>();
        }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public string BandaSonora { get; set; }
        public Studio Studio { get; set; }
        public MovieType MovieType { get; set; }
        public IList<Actor> Actores { get; set; }
        public IList<Review> Reviews { get; set; }
        public IList<Comment> Comments { get; set; }

        // Comentarios -> Utilizador Registado
        // Todas as classes devem ter os metodos Adicionar, Apagar, Actualizar, Ler um, Ler todos

        /// <summary>
        ///  Permite adicionar um actor ao Filme 
        /// </summary>
        /// <param name="actor"></param>

        public void AdicionarActor(Actor actor)
        {
            Actores.Add(actor);
        }

        public void AdicionarComentario(Comment comment)
        {
            Comments.Add(comment);
        }

        /// <summary>
        /// Obter a idade do filme na data atual
        /// </summary>
        /// <returns>int</returns>
        /// 
        public int IdadeFilme()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.Year - Ano;
        }
    }
}