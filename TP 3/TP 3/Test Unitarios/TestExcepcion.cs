using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Entidades;
using Archivos;


namespace Test_Unitarios
{
    [TestClass]
    public class TestExcepcion
    {
        [TestMethod]
        [ExpectedException(typeof(ExcepcionArchivos))]

        public void ValidarExcepcion_CuandoNoSeLeeArchivo()
        {
            string pruebaExc = null;
            List<Paciente> pruebaListaCliente = null;

            //Arrange
            Xml<List<Paciente>> xml = new Xml<List<Paciente>>();

            //Act

            //Assert
            xml.Leer(pruebaExc, out pruebaListaCliente);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionArchivos))]
        public void ValidarExcepcion_CuandoExtensionNoEsJson()
        {
            //Arrange
            Json<string> json = new Json<string>();

            //Act
            bool retorno = json.ValidarExtension("archivo.bin");

            //Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionArchivos))]
        public void ValidarExcepcion_CuandoExtensionNoEsXml()
        {
            //Arrange
            Xml<string> xml = new Xml<string>();

            //Act
            bool retorno = xml.ValidarExtension("archivo.bin");

            //Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionArchivos))]
        public void ValidarExcepcion_CuandoExtensionNoEsTxt()
        {
            //Arrange
            Text json = new Text();

            //Act
            bool retorno = json.ValidarExtension("archivo.bin");

            //Assert
            Assert.IsTrue(retorno);
        }
    }
}
