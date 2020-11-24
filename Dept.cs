using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    class Dept
    {
        public string DeptName
        { get; set; }
        Courses[] listOfCourses;
        public int totalCourse
        {
            get;
            set;
        }
        public Sec Sec
        { get; set; }
        TeachingHours[] teachingHours;
        public int CreditCount
        { get; set; }
        public Dept()
        {
            listOfCourses = new Courses[100];
            teachingHours = new TeachingHours[2100];
        }
        public Dept(string deptName)
        {
            DeptName = deptName;
            listOfCourses = new Courses[100];
            teachingHours = new TeachingHours[2100];
        }
        public void ShowDeptInfo()
        {
            Console.WriteLine("Department Name: " + DeptName);
            Console.WriteLine("Number Of Courses: " + totalCourse);
        }
        public void AddCourse(params Courses[] courses)
        {
            foreach (var course in courses)
            {
                if (totalCourse < 100)
                    listOfCourses[totalCourse++] = course;
            }
        }
        public void RemoveCourse(Courses courses)
        {
            for (int i = 0; i < totalCourse; i++)
            {
                if (courses.CourseID.Equals(listOfCourses[i].CourseID))
                {
                    for (int j = i; j < totalCourse - 1; j++)
                    {
                        listOfCourses[j] = listOfCourses[j + 1];
                    }
                    totalCourse--;
                    break;
                }
            }
        }
        public void AddNewCourseNo(Courses courses, int no)
        {
            courses.AddCourseNo(no);
        }
        public Courses SearchCourse(string id)
        {
            Courses b = null;
            for (int i = 0; i < totalCourse; i++)
            {
                if (listOfCourses[i].CourseID.Equals(id))
                {
                    b = listOfCourses[i];
                    break;
                }
            }
            return b;
        }
        public void ShowAllCourses()
        {
            for (int i = 0; i < totalCourse; i++)
            {
                listOfCourses[i].ShowCInfo();
            }
        }
        public void AddTeachingHours(TeachingHours teachingHour)
        {
            teachingHours[CreditCount++] = teachingHour;
        }
        public void ShowAllCredits()
        {
            for (int i = 0; i < CreditCount; i++)
            {
                Console.WriteLine("Department:");
                teachingHours[i].Dept.ShowDeptInfo();
                Console.WriteLine("Teaching Hours:");
                teachingHours[i].ShowTHInfo();
            }
        }
    }
}
