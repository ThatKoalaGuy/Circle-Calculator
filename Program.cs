using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---CIRCLE CALCULATOR---");
            Console.WriteLine("What do you wish to calculate?");
            Console.WriteLine("Cicumference (1)");
            Console.WriteLine("Surface area (2)");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("What is your radius? (in cm)");
                float r = Convert.ToInt64(Console.ReadLine());

                float cicumference = (float)(2 * 3.14 * r);
                Console.WriteLine($"{cicumference} cm2");
            }

            if (choice == 2)
            {
                Console.WriteLine("What is your radius? (in cm)");
                float r = Convert.ToInt64(Console.ReadLine());

                float area = (float)(3.14 * r * r);
                Console.WriteLine($"{area} cm2 ");
            }

            Console.ReadLine();
        }
    }
}
