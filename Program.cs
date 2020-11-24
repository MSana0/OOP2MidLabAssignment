using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("University Course Management System.");
            
            Courses c = new Courses("Introduction to Programming Language", 000, 3, 5, 1);
            Courses c1 = new Courses("Operating System", 010, 3, 5, 1);

            Sec s1 = new Sec("A", "Introduction to Programming Language", 000, 3, 5.0);
            Sec s2 = new Sec("B", "Introduction to Programming Language", 000, 3, 5.0);
            Sec s3 = new Sec("C", "Introduction to Programming Language", 000, 3, 5.0);
            Sec s4 = new Sec("D", "Introduction to Programming Language", 000, 3, 5.0);
            Sec s5 = new Sec("E", "Introduction to Programming Language", 000, 3, 5.0);
            Sec s6 = new Sec("I", "Operating System", 010, 3, 5);
            Sec s7 = new Sec("J", "Operating System", 010, 3, 5);
            Sec s8 = new Sec("K", "Operating System", 010, 3, 5);
            Sec s9 = new Sec("L", "Operating System", 010, 3, 5);
            Sec s10 = new Sec("M", "Operating System", 010, 3, 5);
            s1.SearchSec(01);

            Console.WriteLine("Seacrhing section ");
            c.SearchSec(01);
            c.ShowAllSecs();
            s1.ShowAllSecs();

            Dept d1 = new Dept("FBA");
            Dept d2 = new Dept("FE");
            Dept d3 = new Dept("FSIT");
            Dept d4 = new Dept("FASS");

            d1.AddCourse(c1, c);
            d1.ShowAllCourses();
            Console.WriteLine("Adding Course");
            d2.AddCourse(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
            d2.ShowAllCourses();

            Console.WriteLine("Faculty of the Courses");
            Faculty f1 = new Faculty("Mahbub Chowdhury Mishu", "0000");
            Faculty f2 = new Faculty("Md. Kishor Morol", "0001");
            Faculty f3 = new Faculty("Fahmida Alam", "0010");
            Faculty f4 = new Faculty("Tanvir Ahmed", "0100");

            TeachingHours t = new TeachingHours("intro to programming language", 3, d3);
            TeachingHours t1 = new TeachingHours("datastructures", 3, d3);
            TeachingHours t2 = new TeachingHours("algorithm", 3, d3);
            TeachingHours t3 = new TeachingHours("java", 3, d3);
            TeachingHours t4 = new TeachingHours("C#", 3, d3);
            TeachingHours t5 = new TeachingHours("AI", 3, d3);
            TeachingHours t6 = new TeachingHours("Accounting", 3, d1);
            TeachingHours t7 = new TeachingHours("COA", 3, d3);
            TeachingHours t8 = new TeachingHours("Direct Current", 3, d2);
            TeachingHours t9 = new TeachingHours("Digital logic design", 3, d2);
            TeachingHours t10 = new TeachingHours("Alternating Current", 3, d2);
            TeachingHours t11 = new TeachingHours("Digital Electronics", 3, d2);
            TeachingHours t12 = new TeachingHours("Economics", 3, d1);
            TeachingHours t13 = new TeachingHours("Bussiness Math", 3, d1);
            TeachingHours t14 = new TeachingHours("Bussiness Communication", 3, d1);
            TeachingHours t15 = new TeachingHours("Research methodology", 3, d3);
            TeachingHours t16 = new TeachingHours("compiler", 3, d3);
            TeachingHours t17 = new TeachingHours("computer graphics", 3, d3);
            TeachingHours t18 = new TeachingHours("data communication", 3, d3);


            Console.WriteLine("Information of the faculty");
            f1.ShowFInfo();
            f1.AddCredit(t, t4, t15, t18);
            f1.ShowAllCredits();
            Console.WriteLine("Other Faculty Information:");
            f3.ShowFInfo();
            f3.AddCredit(t, t1, t2, t3, t4, t5);
            f3.ShowAllCredits();
            Console.ReadKey();
        }
    }
}
