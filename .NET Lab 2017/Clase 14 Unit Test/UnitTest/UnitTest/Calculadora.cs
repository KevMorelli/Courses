using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Calculadora
    {
        public int Sumar(int x, int y) => x + y;

        public int Restar(int x, int y) => x - y;

        public int Multiplicar(int x, int y) => x * y;

        public decimal Dividir(decimal x, decimal y)
        {
            if (y == 0)
                return 0;
            else
                return x / y;
        }
    }
}
