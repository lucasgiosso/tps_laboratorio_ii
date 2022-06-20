using System;
using Entidades;
using Archivos;


namespace TestConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1 = new Paciente("Lucas", "Diaz", "222222", "lucas@prueba.com", "1145659878", "04/06/2022", "11 - 12 hs", EObraSocial.Osde, ETipoConsulta.Nutricion);
            Paciente paciente2 = new Paciente("Martina", "Ron", "1111111", "martina@prueba2.com", "1178963223", "03/06/2022", "13 - 14 hs", EObraSocial.SwissMedical, ETipoConsulta.Ginecologia);

            try
            {
                Console.WriteLine("Pruebas de consola:");
                Console.WriteLine(paciente1.Informacion());

                Console.WriteLine("Prueba de Serialización:");
                Consultorio.Paciente.Add(paciente2);
                Xml<Paciente> xml = new Xml<Paciente>();
                Json<Paciente> json = new Json<Paciente>();
                Console.WriteLine(xml.Guardar(@"./listaClientesConsola.xml",paciente2));
                Console.WriteLine(json.Guardar(@"./listaClientesConsola.json",paciente2));

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
