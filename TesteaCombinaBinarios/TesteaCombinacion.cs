using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using CombinaBinarios;

namespace TesteaCombinaBinarios
{
    [TestFixture]
    public class TesteaCombinacion
    {

        private CombinacionBinarios combinacionBinarios { get; set; }

        [SetUp]
        public void InstaciasAntesDeCadaTest()
        {
            // Arrange
            combinacionBinarios = new CombinacionBinarios();
        }

        [Test]
        public void Combinaciones3()
        {
            // Act
            var result = combinacionBinarios.Combinaciones(3);

            // Assert
            Assert.AreEqual("000 001 010 100 101 ", result);
        }

        [Test]
        public void Combinaciones4()
        {
            // Act
            var result = combinacionBinarios.Combinaciones(4);

            // Assert
            Assert.AreEqual("0000 0001 0010 0100 0101 1000 1001 1010 ", result);
        }

    }
}
