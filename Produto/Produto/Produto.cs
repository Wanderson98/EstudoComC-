using System.Globalization;
namespace Produto {
    internal class Produto {

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() {

        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        public string Nome {
            get { return _nome; }
            set { if (value != null && value.Length > 1) {
                    _nome = value;
                }; 
            }
        }

     
        public double ValotTotalEmEstoque() {
            return Quantidade * Preco;

        }

        public void AdicionarProdutos(int quantidade) {
            this.Quantidade += quantidade;

        }

        public void RemoverProdutos(int quantidade) {
            this.Quantidade -= quantidade;

        }

        public override string ToString() {
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValotTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); ;
        }
    }
}
