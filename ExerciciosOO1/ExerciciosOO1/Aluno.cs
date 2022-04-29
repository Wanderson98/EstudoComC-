using System.Globalization;
namespace ExerciciosOO1 {
    internal class Aluno {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        private double TotalNotas() {
            return Nota1 + Nota2 + Nota3;
        }

        public override string ToString() {
            if (TotalNotas() >= 60.00) {
                return "NOTA FINAL: " + TotalNotas().ToString("F2", CultureInfo.InvariantCulture)
                     + "\nAPROVADO";
            } else {
                return "NOTA FINAL: " + TotalNotas().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nREPROVADO"
                    + "\nFALTARAM: " + (60.00 - TotalNotas() ) + " PONTOS";
            }
        }

    }
}
