using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Atencion
    {
        public delegate void DelegadoClienteAtendido(Atencion atencion, string cliente);

        private static Random random;
        private Queue<string> clientesAlaEspera;
        private DelegadoClienteAtendido clienteAtendido;
        private string nombreBox;

        public int CantidadClientesALaEspera
        {
            get { return clientesAlaEspera.Count;}
        }

        public string NombreBox
        {
            get { return nombreBox; }
        }

        static Atencion()
        {
            random = new Random();
        }

        public Atencion(DelegadoClienteAtendido clienteAtendido, string nombreBox)
        {
            clientesAlaEspera = new Queue<string>();
            this.clienteAtendido = clienteAtendido;
            this.nombreBox = nombreBox;
        }

        public void AgregarCliente(string cliente)
        {
            clientesAlaEspera.Enqueue(cliente);
        }

        public Task IniciarAtencion()
        {
            return Task.Run(AtenderClientes);
        }

        private void AtenderClientes()
        {
            do
            {
                if (clientesAlaEspera.Any())
                {
                    string cliente = clientesAlaEspera.Dequeue();
                    clienteAtendido.Invoke(this,cliente);
                    Thread.Sleep(random.Next(1000, 3000));
                }

            } while (true);
        }
    }
}
