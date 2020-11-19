using System;

namespace University_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course("PL1", 001, 3, 5.0, 1);
            Course c1 = new Course("AI", 003, 3, 5.0, 1);
            Section s = new Section("I", "pl2", 001, 3, 5.0);
            Section s1 = new Section("J", "PL2", 001, 3, 3.0);
            Section s2 = new Section("K", "pl2", 001, 3, 3.0);
            Section s3 = new Section("I", "SE", 002, 3, 3.0);
            Section s4 = new Section("J", "SE", 002, 3, 3.0);
            Section s5 = new Section("K", "SE", 002, 3, 3.0);

            s.SearchSection(001);
            Console.WriteLine("Seacrhing");

            c.SearchSection(001);
            Console.WriteLine("Searching");

            c.ShowInfo();
            Console.WriteLine("Searching");

            s.ShowInfo();
            Console.WriteLine("Searching");

            Departments d = new Departments("FST");
            Departments d2 = new Departments("FBA");
            Departments d3 = new Departments("FASS");

            d.AddCourse(c1, c);
            d.ShowAllCourses();
            Console.WriteLine("Add Course");

            d.AddCourse(s, s1, s2, s3, s4, s5);
            d.ShowAllCourses();
            Console.WriteLine("`Faculty Taking Courses");

            Faculty f = new Faculty("A", "20-001");
            Faculty f1 = new Faculty("B", "20-002");
            Faculty f2 = new Faculty("C", "20-003");
            Teaching_Hour t = new Teaching_Hour("PL1", 3, d);
            Teaching_Hour t1 = new Teaching_Hour("PL2", 3, d);
            Teaching_Hour t2 = new Teaching_Hour("AI", 3, d);
            Teaching_Hour t3 = new Teaching_Hour("OOP1", 3, d);
            Teaching_Hour t4 = new Teaching_Hour("SE", 3, d);
            Teaching_Hour t5 = new Teaching_Hour("CS", 3, d);
            Teaching_Hour t6 = new Teaching_Hour("AC", 3, d2);

            Console.WriteLine("Faculty Information");
            f.ShowInfo();
            f.AddCredit(t, t1, t2, t3, t4, t5);
            f.ShowAllCredits();
            Console.WriteLine("Faculty Information");
            f1.ShowInfo();
            f1.AddCredit(t, t1, t2, t3, t4, t5);
            f1.ShowAllCredits();


        }
    }
}

