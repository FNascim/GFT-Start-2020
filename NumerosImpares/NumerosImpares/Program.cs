using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a < 0)
            {
                Console.WriteLine("O numero deve ser maior que zero. Digite novamente");
                a = Convert.ToInt32(Console.ReadLine());
            }
            int b = Convert.ToInt32(Console.ReadLine());
            while (b < a) 
            {
                Console.WriteLine("O segundo numero deve ser maior que o primeiro. Digite novamente");
                b = Convert.ToInt32(Console.ReadLine());
            } 

            for(int i=a; i <= b; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
