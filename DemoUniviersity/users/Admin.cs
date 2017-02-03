using DemoUniviersity.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUniversity.Users
{
    public class Admin : User
    {

        private static Admin instance;

        private Admin()
        {

        }

        public static Admin GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Admin();
                }
                return instance;
            }
        }

        public override string getInfo()
        {
            return base.ToString();
        }

        public void setPassword(string password)
        {
            this.password = password;
        }
        
        public static bool closeCourse(Course thisCoursetoClose)
        {
            thisCoursetoClose.isClosed = true;
            Console.WriteLine("Registration closed for " + thisCoursetoClose.name);
            return true;
        }



        public bool changeCourseStatus(Course thisCourseToChange)
        {
            thisCourseToChange.isClosed = !(thisCourseToChange.isClosed);
            Console.WriteLine("registration is " + ((thisCourseToChange.isClosed)? "closed" : "open"));
            return true;
        }
        



    }



}
