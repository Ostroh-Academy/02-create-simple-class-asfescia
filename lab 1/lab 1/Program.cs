using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть коефіцієнти a, b, c для квадратного рівняння ax^2 + bx + c = 0");

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            QuadraticEquation equation = new QuadraticEquation(a, b, c);

            if (equation.HasRealRoots())
            {
                Console.WriteLine("Квадратне рівняння має дійсні корені.");
            }
            else
            {
                Console.WriteLine("Квадратне рівняння не має дійсних коренів.");
            }

            Console.ReadLine(); // Чекаємо натискання Enter перед закриттям консолі
        }
    }
}
