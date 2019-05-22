using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //BizzBuzz
            double numdig, m3, m5, m35;
            Console.Write("Digite um número ae: ");
            numdig = double.Parse(Console.ReadLine());
            for (int i = 1; i <= numdig; i++ ) 
            {
                m3 = i % 3;
                m5 = i % 5;
                m35 = m3 + m5;
                if (m35 == 0)
                {
                    Console.WriteLine("BizzBuzz");
                }
                else if (m3 == 0)
                {
                    Console.WriteLine("Bizz");
                }
                else if (m5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            }
        }
    }
}
