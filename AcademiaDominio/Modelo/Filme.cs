using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaDominio.Contratos;

namespace AcademiaDominio.Modelo
{
    /// <summary>
    /// Representa todos os filmes no nosso dominio
    /// </summary>
    public class Filme : Entidade
    {
        /// <summary>
        /// Repository IReposotyr
        /// Genericos? Criar Inser, update,delete
        /// </summary>
        public Filme()
        {
            Actores = new List<Actor>();
            Comentarios = new List<Comentario>();
        }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public IList<Actor> Actores { get; set; }

        // Adicionado 09/11/2022
        public string BandaSonora { get; set; }
        public string Genero { get; set; }
        public IList<Comentario> Comentarios { get; set; }

        // Banda Sonora
        // Genero
        // Comentarios -> Utilizador Registado
        // Reviews (Estrelas)





        // Todas as classes devem ter os metodos Adicionar, Apagar, Actualizar, Ler um, Ler todos

        /// <summary>
        ///  Permite adicionar um actor ao Filme 
        /// </summary>
        /// <param name="actor"></param>

        public void AdicionarActor(Actor actor)
        {
            Actores.Add(actor);
        }

        public void AdicionarComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
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