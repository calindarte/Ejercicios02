using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios02
{
    class Program
    {
        static void Main()
        {   /*Pedir por consola un nombre de persona y el nombre de una ciudad y mostrar por pantalla, el siguiente mensaje "Hola " nombre " 
            bienvenido a " ciudad*/

            string name, city;

            Console.SetCursorPosition(20, 4); Console.Write("Estimado usuario, ingrese su nombre por favor : ");
            name = Console.ReadLine();

            Console.SetCursorPosition(20, 6); Console.Write("Ahora ingrese la ciudad en donde reside : ");
            city = Console.ReadLine();

            Console.SetCursorPosition(20, 8); Console.WriteLine("Hola " + name + " Bienvenido a " + city);
            Console.ReadLine();

        }
    }
}