using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesCesar
{
    class Program
    {

        static string folder = @"C:\Users\Usuario\Desktop\GitRespaldo\Clase 11\Archivos Creados\";

        static void Main(string[] args)
        {
            //Ej01();
            //Ej02();
            //Ej03();
            //Ej04();
            Ej05();



            Console.Read();
        }

        static void Ej01()
        {
            //Write a program in C# Sharp to create a blank file in the disk newly

            var fileName = "mytest.txt";

            if (!File.Exists(folder + fileName))
            {
                File.CreateText(folder + fileName);
                Console.WriteLine("A file created with name mytest.txt");
            }
        }

        static void Ej02()
        {
            //Write a program in C# Sharp to remove a file from the disk

            var fileName = "mytest.txt";

            if (File.Exists(folder + fileName))
            {
                File.Delete(folder + fileName);
                Console.WriteLine("The file mytest.txt deleted successfully");
            }
            else
                Console.WriteLine("File does not exist");
        }

        static void Ej03()
        {
            //Write a program in C# Sharp to create a blank file in the disk if the same file already exists

            var fileName = "mytest.txt";

            if (File.Exists(folder + fileName))
            {
                Ej01();
            }
            else
                Console.WriteLine("No existe el archivo");
        }

        static void Ej04()
        {
            //Write a program in C# Sharp to create a file and add some text

            var fileName = "mytest.txt";

            if (!File.Exists(folder + fileName))
            {
                using (StreamWriter fileStr = File.CreateText(folder + fileName))
                {
                    fileStr.WriteLine("asdasdasdasd");
                    fileStr.WriteLine("ffffffffffffffffffffffff");
                    fileStr.WriteLine("ggggggggggggggggggggggggggggggggggggggggg");
                }
                Console.WriteLine("se creo el archivo mytest.txt con contenido interno");
            }
            else
                Console.WriteLine("Ya existe el archivo");

        }

        static void Ej05()
        {
            //Write a program in C# Sharp to create a file with text and read the file

            var fileName = "mytest.txt";

            if (!File.Exists(folder + fileName))
            {
                using (StreamWriter fileStr = File.CreateText(folder + fileName))
                {
                    fileStr.WriteLine("asdasdasdasd");
                    fileStr.WriteLine("ffffffffffffffffffffffff");
                    fileStr.WriteLine("ggggggggggggggggggggggggggggggggggggggggg");
                }
                Console.WriteLine("se creo el archivo mytest.txt con el siguiente contenido interno:");

                Console.WriteLine(File.ReadAllText(folder + fileName));
            }
            else
                Console.WriteLine("Ya existe el archivo");

        }




    }
}
