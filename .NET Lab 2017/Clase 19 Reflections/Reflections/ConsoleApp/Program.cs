using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person
            //{
            //    Name = "Kevin",
            //    Surname = "Morelli"
            //};

            //var type = person.GetType();

            //Console.Write("Ingrese el nombre de la propiedad a mostrar: ");
            //var property = Console.ReadLine();

            //try
            //{
            //    Console.WriteLine(type.GetProperty(property).GetValue(person));
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("No existe esa propiedad");
            //}
            //try
            //{
            //    Console.Write("Ingrese el nombre de la propiedad a editar: ");
            //    var property = Console.ReadLine();

            //    Console.WriteLine("Valor actual: " + type.GetProperty(property).GetValue(person));

            //    Console.Write("Ingrese el valor para la propiedad a editar: ");
            //    var value = Console.ReadLine();

            //    type.GetProperty(property).SetValue(person, value);
            //    Console.WriteLine(type.GetProperty(property).GetValue(person));
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("No existe esa propiedad");
            //}

            //Console.Write("Ingrese el tipo usuario(Person o Student): ");

            //var typeOfUser = Console.ReadLine();

            ////GetExecutingAssembly()
            //var dynamicType = typeof(Program).Assembly.GetTypes()
            //    .First(c => c.Name == typeOfUser);

            //var user = Activator.CreateInstance(dynamicType);

            //Console.WriteLine(user.GetType());

            var persona = new Person
            {
                Name = "Kevin",
                Surname = "Morelli"
            };

            var std = new Student();

            var studentType = std.GetType();
            var personType = persona.GetType();

            foreach (var prop in personType.GetProperties())
            {
                studentType.GetProperty(prop.Name)
                    .SetValue(std, prop.GetValue(persona));
            }

            //foreach (var method in personType.GetMethods())
            //{
            //    method.Invoke(persona, null);
            //}

            var method = personType.GetMethod("Caminar");
            method.Invoke(persona, null);//new [] {""}

            Console.Read();

        }
    }
}
