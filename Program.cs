using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            string st ="";
            if (n % 2 == 0) st = "Par";
            else st = "Impar";

            Console.WriteLine("El numero ingresado " + n + " es " + st);
            Console.ReadLine();
            
        }
    }
}
