using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Negocio;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Negocio.EntitiesDTO.LibrosDTO LibroEjemplo = new Negocio.EntitiesDTO.LibrosDTO();
                LibroEjemplo.Nombre = "PRUEBA";
                LibroEjemplo.Autor = "autor Prueba";
                LibroEjemplo.FechaPublicacion=DateTime.Now;
                LibroEjemplo.idCategoria = 2;

                new Negocio.Managment.LibroManagment().AltaLibro(LibroEjemplo);
                
            }
            catch (Exception)
            {
                Assert.IsTrue(false, "El alta ha sido FALLIDA");

                throw;
            }
          

        }
    }
}
