using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula35Exercicio01
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double[] Notas { get; set; }

        public Aluno(string nome, double[] notas)
        {
            Nome = nome;
            Notas = notas;
        }

        public void calculoMedia()
        {

        }
    }
}
