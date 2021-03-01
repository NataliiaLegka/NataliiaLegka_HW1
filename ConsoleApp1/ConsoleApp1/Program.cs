using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("Введите длину стороны квадрата -> ");
            string sidetext = Console.ReadLine();
            double squareside = Convert.ToDouble(sidetext);
            double square1 = squareside * squareside;
            Console.WriteLine ("Площадь квадрата равна " + Math.Round(square1, 2));


            Console.Write("Введите длину радиуса круга -> ");
            string radtext = Console.ReadLine();
            double radcircle = Convert.ToDouble(radtext);
            double square2 = Math.PI * radcircle * radcircle;
            Console.WriteLine("Площадь круга равна " + Math.Round(square2, 2));


            Console.ReadKey();
        }
    }
}
