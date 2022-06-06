using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Archivos;
using Excepciones;

namespace Test_Unitarios
{
    [TestClass]
    public class TestExtensiones
    {
        [TestMethod]
        public void ValidarExtension_CuandoEsJson()
        {
            //Arrange
            Json<string> json = new Json<string>();

            //Act
            bool retorno = json.ValidarExtension("archivo.json");

            //Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        public void ValidarExtension_CuandoEsXml()
        {
            //Arrange
            Xml<string> xml = new Xml<string>();

            //Act
            bool retorno = xml.ValidarExtension("archivo.xml");

            //Assert
            Assert.IsTrue(retorno);
        }

        
        [TestMethod]
        public void ValidarExtension_CuandoEsTxt()
        {
            //Arrange
            Text txt = new Text();

            //Act
            bool retorno = txt.ValidarExtension("archivo.txt");

            //Assert
            Assert.IsTrue(retorno);
        }
    }
}
