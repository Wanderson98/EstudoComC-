namespace Primeiro {
    internal class Triangulo {

        public double A;
        public double B;
        public double C;

        
        public double AreaTriangulo() {
            double media, p;
            p = (A + B + C) / 2.0;
            media = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return media;
        }
    }

   
}
