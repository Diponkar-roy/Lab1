using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thry3
{
    public class Student
    {
        string id;
        string name;
        float cgpa;

        public string Id {
            private set { id = value; }
            get { return id; }
        }
        public Student() {
        }
        public Student(string id) {
            this.id = id;
       }
        public void ShowInfo() {
            Id = "3345";
        }


    }
}
