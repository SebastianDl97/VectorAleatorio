using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVectorAleatorio
{
    class Program
    {
        const int MAX = 5000;
        static void Main(string[] args)
        {
            int[] x = new int[MAX];
            leerVector(x);
            Console.WriteLine("\n elemento del vector");
            imprimirVector(x);

        }
        public static void leerVector(int[]x)
        {
            for(int i=0;i<MAX;i++)
            {
                var randomNumero = new Random().Next(1, 5000);
                x[i] = randomNumero++;
            }
        }
        public static void imprimirVector(int[]x)
        {
            for (int i = 0; i < MAX; i++)
                Console.WriteLine("Elemento {0} = {1}", i + 1, x[i]);
            Console.ReadLine();
        }
    }
}
