using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void ProbarSuma()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var suma = calculadora.Sumar(10, 60);

            //Assert
            Assert.IsInstanceOfType(suma, typeof(int));
            Assert.AreEqual(suma, 70);
        }

        [TestMethod]
        public void ProbarResta()
        {
            // Arrange
            var calculadora = new Calculadora();

            //Act
            var resta = calculadora.Restar(10, 60);

            //Assert
            Assert.IsInstanceOfType(resta, typeof(int));
            Assert.AreEqual(resta, -50);
        }

        [TestMethod]
        public void ProbarMultiplicacionGeneral()
        {
            // Arrange
            var calculadora = new Calculadora();

            //Act
            var multiplicacion = calculadora.Multiplicar(10, 60);

            //Assert
            Assert.IsInstanceOfType(multiplicacion, typeof(int));
            Assert.AreEqual(multiplicacion, 600);
        }

        [TestMethod]
        public void ProbarMultiplicacionNegativa()
        {
            // Arrange
            var calculadora = new Calculadora();

            //Act
            var multiplicacion = calculadora.Multiplicar(-10, -60);

            //Assert
            Assert.IsInstanceOfType(multiplicacion, typeof(int));
            Assert.AreEqual(multiplicacion, 600);
        }

        [TestMethod]
        public void ProbarValorDecimalDivision()
        {
            // Arrange
            var calculadora = new Calculadora();

            //Act
            var division = calculadora.Dividir(5, 2);

            //Assert
            Assert.IsInstanceOfType(division, typeof(decimal));
            Assert.AreEqual(division, 2.5m);
        }
        //[ExpectedException(typeof(DividedByZeroException))]
        [TestMethod]
        public void ProbarDividirPorCero()
        {
            // Arrange
            var calculadora = new Calculadora();

            //Act
            var division = calculadora.Dividir(5, 0);

            //Assert
            Assert.IsInstanceOfType(division, typeof(decimal));
            Assert.AreEqual(division, 0m);
        }

    }
}
