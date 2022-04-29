using System;

namespace Aula30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro();
            meuCarro.cor = "Vermelho";

            Console.Write("O motor do meu carro faz ");
            meuCarro.RoncoDoMotos();
            Console.WriteLine("e tem a cor " + meuCarro.cor);
        }
    }

    class Veiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano;

        public void RoncoDoMotos()
        {
            Console.Write("Vrummmmmmmmmm");
        }

        



    }

    class Carro : Veiculo
    {
        public string cor;

    }


}
