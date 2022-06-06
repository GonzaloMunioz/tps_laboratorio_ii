using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;

namespace TestUnitarios
{
    [TestClass]
    public class Tests // TEMA 11 - PRUEBAS UNITARIAS
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void Test_AgregarElemento_CuandoNoHayaElementosEnLaLista_DeberiaRetornarTrue()

            {
                // Arrange
                Controlador<Cliente> controlador = new Controlador<Cliente>();
                Cliente cliente = new Cliente(DateTime.Today, "Gonzalo", "Munioz", "44361856", "Mendoza 892");
                bool expected = true;

                // Act:
                bool actual = controlador + cliente;

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test_AgregarElemento_CuandoHayaDiferentesElementosEnLaLista_DeberiaRetornarTrue()
            {
                // Arrange:
                Controlador<Cliente> controlador = new Controlador<Cliente>();
                Cliente cliente = new Cliente(DateTime.Today, "Gonzalo", "Munioz", "44361856", "Mendoza 892");
                Cliente cliente2 = new Cliente(DateTime.Today, "Juan", "Soto", "25347618", "Av. Corrientes 954");
                bool expected = true;

                // Act
                bool actual = controlador + cliente;
                actual = controlador + cliente2;

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test_AgregarElemento_CuandoElElementoYaEsteEnLaLista_DeberiaRetornarFalse()

            {
                // Arrange
                Controlador<Cliente> controlador = new Controlador<Cliente>();
                Cliente cliente = new Cliente(DateTime.Today, "Gonzalo", "Munioz", "44361856", "Mendoza 892");
                Cliente cliente2 = new Cliente(DateTime.Today, "Juan", "Soto", "25347618", "Av. Corrientes 954");
                bool expected = true;

                // Act
                bool actual = controlador + cliente;
                actual = controlador + cliente2;

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test_ValidarDNI_CuandoElStringQueRecibeTengaOchoCaracteres_DeberiaRetornarTrue()
            {
                // Arrange
                string dni = "12345678";
                bool expected = true;

                // Act
                bool actual = dni.ValidarDNI();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test_ValidarDNI_CuandoElStringQueRecibeNoTengaOchoCaracteres_DeberiaRetornarFalse()
            {
                // Arrange
                string dni = "123456";
                bool expected = false;

                // Act
                bool actual = dni.ValidarDNI();

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Test_ValidarDNI_CuandoElStringQueRecibeSeaNull_DeberiaRetornarFalse()
            {
                // Arrange
                string dni = null;
                bool expected = false;

                // Act
                bool actual = dni.ValidarDNI();

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
