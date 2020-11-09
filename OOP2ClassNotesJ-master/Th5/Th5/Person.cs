using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th5
{
    class Person
    {
        string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string dob;
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        private string bg;
        public string Bg
        {
            get { return bg; }
            set { bg = value; }
        }
        public Person()
        {
            Console.WriteLine("Person Default");
        }
        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("Person 1 parameter");
        }
        public Person(string name,string id)
        {
            this.name = name;
            this.id = id;
            Console.WriteLine("Person 2 parameter");
        }
        public Person(string name, string id,string bg)
        {
            this.name = name;
            this.id = id;
            this.bg = bg;
            Console.WriteLine("Person 3 parameter");
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("ID: "+ id);
            Console.WriteLine("Dob: "+ dob);
            Console.WriteLine("Blood Grp: "+ bg);
        }


    }
}
