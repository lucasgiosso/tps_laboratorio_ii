using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;
using System.Collections.Generic;

namespace Test_Unitarios
{
    [TestClass]
    public class TestArchivos
    {
        /// <summary>
        /// Prueba unitaria que guarda el archivo de tipo de Xml.
        /// </summary>
        [TestMethod]
        public void ValidarArchivos_TestGuardarXml()
        {
            //Arrange           
            Paciente paciente1 = new Paciente("pruebaNom","pruebaApell","111111","prueba@prueba.com","15166","01/01/1900","11 - 12 hs",EObraSocial.Osde,ETipoConsulta.Nutricion);
            Paciente paciente2 = new Paciente("pruebaNom1","pruebaApell2","1111112","prueba2@prueba2.com","2222","01/01/2000","13 - 14 hs",EObraSocial.SwissMedical,ETipoConsulta.Ginecologia);

            Xml<List<Paciente>> xml = new Xml<List<Paciente>>();

            List<Paciente> pruebaLista = new List<Paciente>();

            //Act
            pruebaLista.Add(paciente1);
            pruebaLista.Add(paciente2);
            bool pudoGuardar = xml.Guardar("TestArchivo.xml",pruebaLista);

            //Assert
            Assert.IsTrue(pudoGuardar);
        }

        /// <summary>
        /// Prueba unitaria que leer el archivo de tipo de Xml.
        /// </summary>
        [TestMethod]
        public void ValidarArchivos_TestLeerXml()
        {
            //Arrange           
            Paciente paciente1 = new Paciente("pruebaNom", "pruebaApell", "111111", "prueba@prueba.com", "15166", "01/01/1900", "11 - 12 hs", EObraSocial.Osde, ETipoConsulta.Nutricion);
            Paciente paciente2 = new Paciente("pruebaNom1", "pruebaApell2", "1111112", "prueba2@prueba2.com", "2222", "01/01/2000", "13 - 14 hs", EObraSocial.SwissMedical, ETipoConsulta.Ginecologia);

            Xml<List<Paciente>> xml = new Xml<List<Paciente>>();

            List<Paciente> pruebaLista = new List<Paciente>();

            //Act
            pruebaLista.Add(paciente1);
            pruebaLista.Add(paciente2);
            xml.Guardar("TestArchivo.xml", pruebaLista);
            bool pudoLeer = xml.Leer("TestArchivo.xml", out pruebaLista);

            //Assert
            Assert.IsTrue(pudoLeer);
        }

        /// <summary>
        /// Prueba unitaria que guarda el archivo de tipo de Json.
        /// </summary>
        [TestMethod]
        public void ValidarArchivos_TestGuardarJson()
        {
            //Arrange           
            Paciente paciente1 = new Paciente("pruebaNom", "pruebaApell", "111111", "prueba@prueba.com", "15166", "01/01/1900", "11 - 12 hs", EObraSocial.Osde, ETipoConsulta.Nutricion);
            Paciente paciente2 = new Paciente("pruebaNom1", "pruebaApell2", "1111112", "prueba2@prueba2.com", "2222", "01/01/2000", "13 - 14 hs", EObraSocial.SwissMedical, ETipoConsulta.Ginecologia);

            Json<List<Paciente>> json = new Json<List<Paciente>>();

            List<Paciente> pruebaLista = new List<Paciente>();

            //Act
            pruebaLista.Add(paciente1);
            pruebaLista.Add(paciente2);
            bool pudoGuardar = json.Guardar("TestArchivo.json", pruebaLista);

            //Assert
            Assert.IsTrue(pudoGuardar);
        }

        /// <summary>
        /// Prueba unitaria que leer el archivo de tipo de Json
        /// </summary>
        [TestMethod]
        public void ValidarArchivos_TestLeerJson()
        {
            //Arrange           
            Paciente paciente1 = new Paciente("pruebaNom", "pruebaApell", "111111", "prueba@prueba.com", "15166", "01/01/1900", "11 - 12 hs", EObraSocial.Osde, ETipoConsulta.Nutricion);
            Paciente paciente2 = new Paciente("pruebaNom1", "pruebaApell2", "1111112", "prueba2@prueba2.com", "2222", "01/01/2000", "13 - 14 hs", EObraSocial.SwissMedical, ETipoConsulta.Ginecologia);

            Json<List<Paciente>> json = new Json<List<Paciente>>();

            List<Paciente> pruebaLista = new List<Paciente>();

            //Act
            pruebaLista.Add(paciente1);
            pruebaLista.Add(paciente2);
            json.Guardar("TestArchivo.json", pruebaLista);
            bool pudoLeer = json.Leer("TestArchivo.json", out pruebaLista);

            //Assert
            Assert.IsTrue(pudoLeer);
        }
    }
}
