using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_TEST_12_04_24_2
{
    public class Program
    {
        public static void KoorPl(double x, double y) {
            if (x > 0 && y > 0) 
            {
                Console.WriteLine("Точка в 1 четверти");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка в 2 четверти");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка в 3 четверти");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка в 4 четверти");
            }

            else if (x == 0 && y > 0)
            {
                Console.WriteLine("Точка между 1 и 2 четвертями");
            }
            else if (x < 0 && y == 0)
            {
                Console.WriteLine("Точка между 2 и 3 четвертями");
            }
            else if (x == 0 && y < 0)
            {
                Console.WriteLine("Точка между 3 и 4 четвертями");
            }
            else if (x > 0 && y == 0)
            {
                Console.WriteLine("Точка между 1 и 4 четвертями");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Точка в начале координат");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Точка на плоскости");
            Console.Write("x = ");
            var x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            var y = double.Parse(Console.ReadLine());
            KoorPl(x, y);
            Console.ReadKey();
        }
    }
}
