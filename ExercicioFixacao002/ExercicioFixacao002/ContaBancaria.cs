using System.Globalization;
namespace ExercicioFixacao002 {
    internal class ContaBancaria {

        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public int NumeroConta { get; private set; }

        public ContaBancaria(string nome, int numeroConta) {
            Titular = nome;
            NumeroConta = numeroConta;
        }

        public ContaBancaria(string nome, int numeroConta, double depositoInicial) : this(nome, numeroConta) {
            DepositoConta(depositoInicial);
        }
        public void DepositoConta(double quantia) {
            Saldo += quantia;
        }
        public void SaqueConta(double quantia) {
            Saldo -= quantia + 5.0;
        }
        public override string ToString() {
            return "Conta " + NumeroConta
                + ", Titular: " + Titular
                + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
