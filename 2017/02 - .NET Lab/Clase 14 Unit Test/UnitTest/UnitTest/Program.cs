using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();

            var resultado = c.Sumar(1, 5);

            Console.WriteLine(resultado);



            Console.Read();
        }
    }
}
