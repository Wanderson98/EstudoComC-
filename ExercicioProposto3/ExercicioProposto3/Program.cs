namespace ExercicioProspoto3 {

    class Program {

        const int senha = 2002;
        static void Main(string[] args) {
            //exercicio1
            Console.WriteLine("Digite sua senha: ");
            int tent = int.Parse(Console.ReadLine());

            while (tent != senha) {
                Console.WriteLine("Senha Invalida");
                Console.WriteLine("Digite sua senha: ");
                tent = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!");

            //exercicio2
            Console.WriteLine("Digite os dados x e Y");
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != 0 && y != 0) {
                Console.WriteLine(quadrado(x, y));
                Console.WriteLine("Digite os dados x e Y");
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

            }
            Console.WriteLine("Dados Nulos");

            //exercicio3
            Console.WriteLine("Digite o Código sendo:" +
                "\n1 - Alcool " +
                "\n2 - Gasolina " +
                "\n3 - Disel " +
                "\n4 - Para Sair ");
            int cod = int.Parse(Console.ReadLine());
            i   t qtdAlc = 0, qtdGaso = 0, qtdDisel = 0;
            while (cod != 4) {
                if (cod < 1 || cod > 4) {
                    Console.WriteLine("Digite novo Código: ");
                } else if (cod == 1) {
                    qtdAlc++;
                } else if (cod == 2) {
                    qtdGaso++;
                } else if (cod == 3) {
                    qtdDisel++;
                }
                Console.WriteLine("Digite o Código sendo:" +
                "\n1 - Alcool " +
                "\n2 - Gasolina " +
                "\n3 - Disel " +
                "\n4 - Para Sair ");
                cod = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado !!" +
                "\nAlcool: " + qtdAlc +
                "\nGasolina: " + qtdGaso +
                "\nDisel: " + qtdDisel);
        }

        //exercicio2
        static string quadrado(int a, int b) {
            string qua = null;
            if (a > 0 && b > 0) {
                qua = "primeiro";
            } else if (a < 0 && b > 0) {
                qua = "segundo";
            } else if (a > 0 && b < 0) {
                qua = "quarto";
            } else {
                qua = "terceiro";
            }
            return qua;
        }


    }
}