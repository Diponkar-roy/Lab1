using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th2
{
    class Student
    {
        string name; //fields
        string id;
        float cgpa;

        void ShowInfo() {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Cgpa: " + cgpa);
        }

    }
}
