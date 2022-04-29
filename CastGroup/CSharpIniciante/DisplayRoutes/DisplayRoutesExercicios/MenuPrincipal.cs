using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRoutesExercicios
{
    public class MenuPrincipal
    {

        public void CriaMenu()
        {
            Clientes cl = new Clientes();
            Console.WriteLine("--- MENU DE OPÇÕES ----" +
                "\n-------------------------------" +
                "\n| 1 - Cadastrar Clientes " +
                "\n| 2 - Listar Clientes " +
                "\n| 3 - Remover Cliente" +
                "\n| 4 - Para sair! " +
                "\n-------------------------------");
            Console.Write("Digite a opção desejada: ");
            int resp = int.Parse(Console.ReadLine());

            switch (resp)
            {
                case 1:
                    cl.CadastrarCliente();
                    break;
                case 2:
                    cl.ListarCliente();
                    break;
                case 3:
                    cl.RemoverCliente();
                    break;
                case 4:
                    Console.WriteLine("Você saiu!");
                    break;
                default:
                    Console.WriteLine("Código Inválido ");
                    break;
            }
        }
    }
}
