using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcademiaDominio.Modelo;
using System.Linq;

namespace AcademiaDominioTeste
{
    [TestClass]
    public class TesteFilme
    {
        [TestMethod]
        public void TestIdadeFilme()
        {
            // Prepare
            Movie filme = new Movie { Nome = "A", Ano = 1920 };

            // Execute
            var r = filme.IdadeFilme();

            // Assert
            Assert.AreEqual(r, 102);
        }

        [TestMethod]
        public void TestAdicionaActor()
        {
            // Prepare
            Movie filme = new Movie { Nome = "A", Ano = 1972 };

            // Execute
            filme.AdicionarActor(new Actor { Nome = "A" });
            filme.AdicionarActor(new Actor { Nome = "A" });
            filme.AdicionarActor(new Actor { Nome = "A" });
            var r1 = filme.Actores.Count();

            //Assert
            Assert.AreEqual(r1, 3);
        }

        [TestMethod]
        public void TestAdicionaGenero()
        {
            // Prepare
            Movie filme = new Movie { Nome = "A", Ano = 1972, Genero = "Terror" };

            // Execute + Assert
            Assert.AreEqual(filme.Genero, "Terror");
        }

        [TestMethod]
        public void TestAdicionaComentario()
        {
            // Prepare
            Movie filme = new Movie { Nome = "A", Ano = 1972 };
            ApplicationUser applicationUser = new ApplicationUser { UserName = "A" };

            // Execute
            filme.AdicionarComentario(new Comment { ApplicationUser = applicationUser, Texto = "COmentario1" });
            filme.AdicionarComentario(new Comment { ApplicationUser = applicationUser, Texto = "COmentario2" });
            var r1 = filme.Comentarios.Count();

            //Assert
            Assert.AreEqual(r1, 2);
        }

    }
}

