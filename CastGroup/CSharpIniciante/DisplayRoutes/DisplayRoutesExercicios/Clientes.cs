using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoutesExercicios
{
    internal class Clientes
    {
        public String Nome { get; private set; }
        public double Salario { get; private set; }
        public string Email { get; private set; }

        public Clientes(string nome, double salario, string email)
        {
            Nome = nome;
            Salario = salario;
            Email = email;
        }

        public void CadastrarCliente()
        {
            Console.WriteLine("Método: Cadastrar Cliente");
        }
        public void ListarCliente()
        {
            Console.WriteLine("Método: Listar Cliente");

        }
        public void RemoverCliente()
        {
            Console.WriteLine("Método: Remover Cliente");
        }
    }
}
