using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraZonaLipolitica.Services
{
    internal class CalculadoraZonaLipolitica1
    {
        public int Idade { get; set; }
        public double FrequenciaMaxima { get; private set; }
        public double FrequenciaMinima { get; private set; }
        public double FrequenciaDeRepouso { get; private set; }
        public double InsentidadeTreino { get; set; }
        public char Sexo { get; set; }

        public CalculadoraZonaLipolitica1(int idade,double frequenciaRepouso, double insentidadeTreino, char sexo)
        {
            Idade = idade;
            FrequenciaDeRepouso = frequenciaRepouso;
            InsentidadeTreino = insentidadeTreino /100 ;
            Sexo = sexo;
        }

        public void CalcularZona()
        {
            //calculo das frequencias cardiacas maxima e minima
            if (Sexo == 'f')
            {
                if (Idade >= 25)
                {
                    FrequenciaMaxima = ((200 - Idade + 12) - FrequenciaDeRepouso) * InsentidadeTreino + FrequenciaDeRepouso;
                    FrequenciaMinima = ((200 - Idade - 12) - FrequenciaDeRepouso) * InsentidadeTreino + FrequenciaDeRepouso;
                }
                else
                {
                    FrequenciaMaxima = ((200 - Idade + 10) - FrequenciaDeRepouso) * InsentidadeTreino + FrequenciaDeRepouso;
                    FrequenciaMinima = ((200 - Idade - 10) - FrequenciaDeRepouso) * InsentidadeTreino + FrequenciaDeRepouso;
                }
                Console.WriteLine("A zona alvo de frequência cárdiaca é entre: {0:F2} e {1:F2}", FrequenciaMinima, FrequenciaMaxima);
            }
            else if (Sexo == 'm')
            {
                if (Idade >= 25)
                {
                    FrequenciaMaxima = ((220 - Idade + 12) - FrequenciaDeRepouso) * InsentidadeTreino + FrequenciaDeRepouso;
                    FrequenciaMinima = ((220 - Idade - 12) - FrequenciaDeRepouso) * InsentidadeTreino + FrequenciaDeRepouso;
                }
                else
                {
                    FrequenciaMaxima = ((220 - Idade + 10) - FrequenciaDeRepouso) * InsentidadeTreino + FrequenciaDeRepouso;
                    FrequenciaMinima = ((220 - Idade - 10) - FrequenciaDeRepouso) * InsentidadeTreino + FrequenciaDeRepouso;
                }
                Console.WriteLine("A zona alvo de frequência cárdiaca é entre: {0:F2} e {1:F2}", FrequenciaMinima, FrequenciaMaxima);
            }
        }
    }
}
