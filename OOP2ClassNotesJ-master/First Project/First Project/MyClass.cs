using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    public class MyClass
    {
        static void testc(ref string  a, ref string c) {
            string t = a;
            a = c;
            c = t;
        }
        static void Main(string[] args)
        {
            string name = "Tanvir";
            Console.WriteLine("My name is " + name);
            string a = "ac";
            string c = "ad";
            testc( ref a,  ref c);
            Console.WriteLine(a + " " + c);

           /* for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even Number: " + i);
                }
                else
                    Console.WriteLine("Odd Number: " + i);

            }*/
        }
    }
}
