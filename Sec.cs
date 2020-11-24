using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    class Sec : Courses
    {
        private string secName;
        public string SecName
        {
            get { return secName; }
            set { secName = value; }
        }

        public Sec() { }
        public Sec(string secName, string courseName, int courseID, int courseCredit, double courseTeachingHours) : base(courseName, courseID, courseCredit, courseTeachingHours, 0)
        {
            this.secName = secName;

        }
        virtual public void ShowAllSecs()
        {
            Console.WriteLine("Section: " + secName);
        }
    }
}
