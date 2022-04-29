using System.Globalization; 
namespace ExercicioListas {
    internal class Funcionario {

        public int IdFuncionario { get; private set; }
        public string NomeFuncionario { get; set; }
        public double SalarioFuncionario { get; private set; }

        public Funcionario(int id, string nome, double salario) {
            IdFuncionario = id;
            NomeFuncionario = nome;
            SalarioFuncionario = salario;
        }

        public void AumentoSalario(double taxa) {
            SalarioFuncionario *= (taxa / 100 + 1);
        }

        public override string ToString() {
            return IdFuncionario
                + ", "
                + NomeFuncionario
                + ", "
                + SalarioFuncionario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
