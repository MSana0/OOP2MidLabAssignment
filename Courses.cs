using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    class Courses
    {
        public int N
        {
            get; set;
        }
        private string courseName;
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        private int courseID;
        public int CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }
        private int courseCredit;
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }
        private double courseTeachingHours;
        public double CourseTH
        {
            get { return courseTeachingHours; }
            set { courseTeachingHours = value; }
        }
        private Sec[] sec;
        private int secs;
        public int SecCount
        {
            get { return secs; }
            set { secs = value; }
        }
        public Courses()
        {
            sec = new Sec[20];
            secs = 0;
        }
        public Courses(string courseName,int courseID, int courseCredit,double courseTeachingHours, int N)
        {
            this.courseName = courseName;
            this.courseID = courseID;
            this.courseCredit = courseCredit;
            this.courseTeachingHours = courseTeachingHours;
            this.N = N;
            sec = new Sec[20];
            secs = 0;
        }
        public void AddSec(params Sec[] sec)
        {
            foreach(var s in sec)
            {
                if (secs<20)
                {
                    this.sec[secs++] = s;
                }
                else { Console.WriteLine("Maximum section limit reached"); }
            }
        }
        public void ShowAllSecs()
        {
            for (int i = 0; i < secs; i++)
            {
                sec[i].ShowCInfo();
            }
        }
        public Sec SearchSec(int secNo)
        {
            Sec x = null;
            for(int i = 0;i<secs;i++)
            {
                if(sec[i].CourseID.Equals(secNo))
                {
                    x = sec[i];
                    break;
                }
            }
            return x;
        }
        public void ShowCInfo()
        {
            Console.WriteLine("Course Name: " +courseName);
            Console.WriteLine("Course ID: " + courseID);
            Console.WriteLine("Course credit: " + courseCredit);
            Console.WriteLine("Course hours: " + courseTeachingHours);
        }
        public void AddCourseNo(int x)
        { N += x; }
    }
}
