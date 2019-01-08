using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un directorio y nombre de archivo:");

            var path = Console.ReadLine();

            if (!File.Exists(path))
            {
                File.CreateText(path);
                Console.WriteLine("Creado!");
            }
            else
                Console.WriteLine("Ya existe!");

            Console.Read();

        }
    }
}
