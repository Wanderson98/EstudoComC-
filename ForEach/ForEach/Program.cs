namespace ForEach {
    class Program {
        static void Main(string[] args) {

            string[] vec = new string[] { "Maria", "Joao", "Pedro" };

            for (int i = 0; i < vec.Length; i++) {
                Console.WriteLine(vec[i]) ;
            }
            Console.WriteLine("-----------------------------");

            foreach (string vect in vec) {
                Console.WriteLine(vect);
            }
        }
    }
}