
namespace ExercicioFixacaoOO {
    internal class ConversorDeMoeda {

        private static double IOF = 6.00;
       

        public static double ConversosDeMoeda(double cot, double qtd) {
            return (cot * qtd) * (IOF / 100 + 1);
        }


    }
}
