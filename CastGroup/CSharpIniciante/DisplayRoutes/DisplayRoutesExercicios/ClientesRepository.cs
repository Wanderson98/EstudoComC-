using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoutesExercicios
{
    internal class ClientesRepository
    {

        public static List<Clientes> InicializeCliente()
        {
            List<Clientes> clientes = new List<Clientes>();

            clientes.Add(new Clientes("André", 5000.0, "andre@gmail.com"));
            clientes.Add(new Clientes("João Paulo", 3000.0, "jp@gmail.com"));
            clientes.Add(new Clientes("Mariana Rios", 4350.0, "mariana@gmail.com"));
            clientes.Add(new Clientes("Sandy Marielly", 13350.0, "sandy@gmail.com"));

            return clientes;
        }
    }
}
