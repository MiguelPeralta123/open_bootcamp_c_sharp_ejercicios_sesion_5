using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe tu nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Escribe tu email: ");
            string email = Console.ReadLine();
            Console.Write("¿Cuál es el precio del articulo que desea comprar? ");
            double precio = Convert.ToDouble(Console.ReadLine());
            Console.Write("¿Cuenta con algún cúpón de descuento? (s/n): ");
            char respuesta = Convert.ToChar(Console.ReadLine());
            bool cupon;

            Console.WriteLine("");

            if (respuesta == 's')
            {
                cupon = true;
                Console.Write("¿Cuál es el porcentaje del descuento? ");
                double porcentaje = Convert.ToDouble(Console.ReadLine());

                // Imprimiendo el resultado
                Console.WriteLine($"\nEl cliente {nombre} tiene el correo {email}. El estatus de su cupón es: {cupon}.");
                Console.WriteLine($"El precio normal del producto es ${precio}.");
                Console.WriteLine($"El precio después del descuento es ${precio * (1 - porcentaje / 100)}.");
            } else
            {
                cupon = false;

                // Imprimiendo el resultado
                Console.WriteLine($"El cliente {nombre} tiene el correo {email}. El estatus de su cupón es: {cupon}.");
                Console.WriteLine($"El precio del producto es ${precio}.");
                Console.WriteLine("El cliente no cuenta con ningún descuento :(");
            }
        }
    }
}
