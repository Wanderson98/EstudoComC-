using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut {
    internal class Calculadora {

        public static void Triple(ref int x) {
            x = x * 3;
        }

        public static void Triple( int origem, out int resultado) {
            resultado = origem * 3;
        }
    }
}
