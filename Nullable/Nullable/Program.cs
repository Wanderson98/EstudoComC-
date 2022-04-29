namespace Nullable {

    class Program {
        static void Main(string[] args) {

            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            } else {
                Console.WriteLine("X is Null");
            }
            if (y.HasValue) {
                Console.WriteLine(y.Value);
            } else {
                Console.WriteLine("Y is null");
            }

            double? z = null;
            double? a = 10;

            double b = x ?? 5;
            double c = y ?? 5;

            Console.WriteLine(b);
            Console.WriteLine(c);
            
        }
    }
}