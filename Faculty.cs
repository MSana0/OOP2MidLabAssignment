using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    class Faculty
    {
        public string FacultyName
        { get; set; }
        public string FacultyId
        { get; set;}
        TeachingHours[] teachingHours;
        public int CreditCount
        { get; set; }
        public Dept Dept
        { get; set; }
        public Faculty(string fName, string fId)
        {
            this.FacultyName = fName;
            this.FacultyId = fId;
            teachingHours = new TeachingHours[100];
        }
        public void ShowFInfo()
        {
            Console.WriteLine("Name if Faculty: " + FacultyName);
            Console.WriteLine("Faculty Id: " + FacultyId);
            Console.ReadKey();
        }
        public void AddCredit(params TeachingHours[] teachingHours)
        {
            foreach (var a in teachingHours)
            {
                if (CreditCount < 9)
                {
                    this.teachingHours[CreditCount++] = a;
                }
                else
                {
                    Console.WriteLine("Maximum credit load can not be more than 20 in regular semester.");
                    Console.WriteLine("Current credit load: " + a.CreditCount + "can not register for anymore courses.");
                }
            }
        }
        public void ShowAllCredits()
        {
            Console.WriteLine("Course/Credits list:");
            for (int i = 0; i < CreditCount; i++)
            {
                teachingHours[i].ShowTHInfo();
            }
        }
    }
}
