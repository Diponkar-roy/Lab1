using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th4
{
    enum Day 
    {
        Saturday=10,
        Sun=12,
        Mon,
        Tues,
        Wed=150,
        Thu=15,
        Fri
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int [2, 3];
            int[,] arr1 = new int[,]
                {
                    {1,2,3 },
                    {4,5,6 },
                    {7,8,9 }
                };
            Console.WriteLine(arr1[1,2]);
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(arr1[i,j]+" ");
                }
                Console.WriteLine();
            }
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 11, 12, 13};
            jagged[2] = new int[] { 21, 22,};

            Console.WriteLine(jagged[1][2]);

            for (int i = 0; i < jagged.Length; i++)
            {
                 for(int j=0; j<jagged[i].Length;j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
            var date = (Day)10;
            var date2 = (int)Day.Saturday;
            Console.WriteLine(date2);
           
           

        }
    }
}
