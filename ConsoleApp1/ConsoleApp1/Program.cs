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
            bool square1Calculated = false;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\nВведите длину стороны квадрата -> ");
                string sidetext = Console.ReadLine();
                double squareside = Convert.ToDouble(sidetext);

                if (squareside > 0)
                {
                    double square1 = squareside * squareside;
                    Console.WriteLine("\nПлощадь квадрата равна " + Math.Round(square1, 2));
                    square1Calculated = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Число должно быть больше нуля");
                }

            }
            if (!square1Calculated) 
            {
                Console.WriteLine("\nВы исчерпали количество попыток");
                Random rnd = new Random();
                double randomSide = rnd.NextDouble()*4.5+0.5;
                
                Console.WriteLine("Поэтому будет посчитан случайный квадрат со стороной " + randomSide);
                double square1 = randomSide * randomSide;
                Console.WriteLine("\nПлощадь случайного квадрата равна " + Math.Round(square1, 2));
            }


            bool square2Calculated = false;
            for (int i = 0; i < 3; i++)
            {

                Console.Write("\nВведите длину радиуса круга -> ");
                string radtext = Console.ReadLine();
                double radcircle = Convert.ToDouble(radtext);

                if (radcircle > 0)
                {
                    double square2 = Math.PI * radcircle * radcircle;
                    Console.WriteLine("\nПлощадь круга равна " + Math.Round(square2, 2));
                    square2Calculated = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Число должно быть больше нуля");
                }
            }
            if (!square1Calculated)
            {
                Console.WriteLine("\nВы исчерпали количество попыток");
                Random rnd = new Random();
                double randomRad = rnd.NextDouble() * 4.5 + 0.5;

                Console.WriteLine("Поэтому будет посчитан случайный круг с радиусом " + randomRad);
                double square1 = Math.PI * randomRad * randomRad;
                Console.WriteLine("\nПлощадь случайного круга равна " + Math.Round(square1, 2));
            }


            Console.ReadKey();
        }
    }
}
