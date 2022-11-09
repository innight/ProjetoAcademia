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
            Filme filme = new Filme { Nome = "A", Ano = 1920 };

            // Execute
            var r = filme.IdadeFilme();

            // Assert
            Assert.AreEqual(r, 102);
        }

        [TestMethod]
        public void TestAdicionaActor()
        {
            // Prepare
            Filme filme = new Filme { Nome = "A", Ano = 1972 };

            // Execute
            filme.AdicionarActor(new Actor { Nome = "A" });
            filme.AdicionarActor(new Actor { Nome = "A" });
            filme.AdicionarActor(new Actor { Nome = "A" });
            var r1 = filme.Actores.Count();

            //Assert
            Assert.AreEqual(r1, 3);
        }
    }
}

