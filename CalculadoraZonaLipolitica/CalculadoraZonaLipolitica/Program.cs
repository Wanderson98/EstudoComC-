using System;
using CalculadoraZonaLipolitica.Services;

namespace CalculadoraZonaLipolitica {
    class Program {
        static void Main(string[] args) {
            //declaração de variaveis
            int cod = 0;
            CalculadoraZonaLipolitica1 calculo;
            //inserção dos dados solicitados
            do {
                Console.Write("Digite a sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Digite a sua frequência cardiaca em repouso: ");
                double freqRepouso = float.Parse(Console.ReadLine());

                Console.Write("Digite a intensidade do treino (em %): ");
                float intensidade = float.Parse(Console.ReadLine());
                
                Console.Write("Digite seu sexo. Sendo 'M' para Masculino e 'F' para feminino: ");
                char sexo = char.Parse(Console.ReadLine().ToLower());

                calculo = new CalculadoraZonaLipolitica1(idade, freqRepouso, intensidade, sexo);

                calculo.CalcularZona();

                Console.Write("Digite qualquer número para continuar ou 1 para sair: ");
                cod = int.Parse(Console.ReadLine());

            } while (cod != 1);



        }
    }
}
