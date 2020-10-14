using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace first_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello \n Diponkar");

            //2

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int sum = x + y;
            Console.WriteLine("Ans no 2: " + sum);

            //3

            int div = x / y;
            Console.WriteLine("Ans no 3: " + div);

            //4

            int a = 5;
            int b = 8;
            int c = 6;

            int result = -a + b * c;
            Console.WriteLine("Ans no a: " + result);

            a = 55;
            b = 9;
            c = 9;
            int reslt = (a + b) % c;
            Console.WriteLine("Ans no b: " + reslt);

            a = 20;
            b = 3;
            c = 5;
            x = 8;
            int rlt = a + (-b * c / x);
            Console.WriteLine("Ans no c: " + rlt);

            a = 5;
            b = 8;
            c = 3;
            x = 2;
            int re = a + (a * c) / c * x - b % c;
            Console.WriteLine("Ans no d: " + re);

        }
    }
}
