using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("18-38089-2");
            s.Id = "18-38089-2";
            Console.WriteLine(s.Id);
        }
    }
}
