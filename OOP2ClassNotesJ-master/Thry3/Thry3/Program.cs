using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thry5;
namespace Thry3
{
    class Program
    {
        static void Swap(ref int a, ref int c)
        {
            int temp = a;
            a = c;
            c = temp;
        }
        static void Sum_Sub(int a, int c, out int sum, out int sub)
        {
            sum = a + c;
            sub = a - c;
        }
        static int Add(params int[] a)
        {
            int sum = 0;
            foreach (int v in a) {
                sum += v;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Student s = new Student("10-2456-1");
            Teacher t = new Teacher();
            Console.WriteLine(s.Id);
            int a = 10;
            int c = 12;
            Console.WriteLine("a: {0} c: {1}",a, c);
            Swap(ref a, ref c);
            Console.WriteLine("a: {0} c: {1}", a, c);
            int sum;
            int sub;
            Sum_Sub(a, c, out sum, out sub);
            Console.WriteLine("Sum: {0} Sub: {1}", sum, sub);

            int[] arr= new int[5];
            arr[0] = 10;
            string[] names = { "Tanvir", "Karim", "Rahim" };
            double[] nums = new double[] { 10.6, 20.5, 30.9 };

            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine(names[i]);
            }
            double sum_d = 0;
            foreach (double v in nums) {
                sum_d += v;
            }

            Console.WriteLine("The sum of parameters: {0}",Add(10,15));
            Console.WriteLine("The sum of parameters: {0}", Add(10, 15,18));
            Console.WriteLine("The sum of parameters: {0}", Add(10, 15,12,14,15));
            Console.WriteLine("The sum of parameters: {0}", Add());



        }
    }
}
