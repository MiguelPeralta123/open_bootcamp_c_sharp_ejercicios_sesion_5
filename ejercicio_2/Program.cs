using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lenguajes = new List<string>()
            {
                "1.- C#.",
                "2.- Java.",
                "3.- Python.",
                "4.- JavaScript.",
                "5.- PHP.",
                "6.- Go."
            };

            foreach (var lenguaje in lenguajes)
            {
                Console.WriteLine(lenguaje);
            }

            Console.Write("Escriba el número del lenguaje que le interese: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            switch (numero) {
                case 1:
                    Console.WriteLine("Hola mundo desde C#!");
                    break;
                case 2:
                    Console.WriteLine("Hola mundo desde Java!");
                    break;
                case 3:
                    Console.WriteLine("Hola mundo desde Python!");
                    break;
                case 4:
                    Console.WriteLine("Hola mundo desde JavaScript!");
                    break;
                case 5:
                    Console.WriteLine("Hola mundo desde PHP!");
                    break;
                case 6:
                    Console.WriteLine("Hola mundo desde Go!");
                    break;
                default:
                    Console.WriteLine("El elemento que seleccionado no existe");
                    break;
            }
        }
    }
}
