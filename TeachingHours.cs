using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    class TeachingHours
    {
        public string CourseName
        { get; set; }
        public int CourseCreditNo
        { get; set; }
        public Dept Dept
        { get; set; }
        Courses[] courses;
        public int CreditCount
        { get; set; }
        public TeachingHours()
        {
            courses = new Courses[5];
        }
        public TeachingHours(string courseName, int courseCreditNo, Dept dept)
        {
            this.CourseName = courseName;
            this.CourseCreditNo = courseCreditNo;
            this.Dept = dept;
            courses = new Courses[5];
        }
        public void AddTeachingHours(params Courses[] courses)
        {
            foreach (var course in courses)
            {
                if (CreditCount < 9)
                    this.courses[CreditCount++] = course;
            }
        }
        public void ShowTHInfo()
        {
            Console.WriteLine("Course Name: " + CourseName);
            Console.WriteLine("Course Credit Number : " + CourseCreditNo);
            for (int i = 0; i < CreditCount; i++)
            {
                courses[i].ShowCInfo();
            }
        }
    }
}
