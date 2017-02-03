using DemoUniviersity.courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity.Users;

namespace DemoUniviersity.Courses
{
    public class Course : Icourse
    {

        /// <summary>
        /// field values for Courses
        /// 
        /// </summary>
        public string name; 
        private List<Student> studentRoster = new List<Student>();
        private string major;
        private DateTime timeOfDay;
        private int creditHour;
        public delegate bool CloseRegistration(Course thisCourseToClose);

        public CloseRegistration closeReg = null;
        public bool isClosed = false;



        /// <summary>
        /// Default Constructor
        /// </summary>
        public Course(string name, DateTime timeOfDay, int creditHour = 1, string major = "elective")
        {
            this.name = name;
            this.creditHour = creditHour;
            this.timeOfDay = timeOfDay;
            this.major = major;
        }


        public bool isFull
        {
            get
            {
                return studentRoster.Count == Global.maxStudents;
            }

        }

        public int rosterCount
        {
            get
            {
                return studentRoster.Count;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                //name = value;
            }
        }

        public bool addStudent(Student student)
        {
            SpaceCheck(studentRoster.Count + 1);
            studentRoster.Add(student);
            if (closeReg != null && isFull)
            {
                closeReg(this);
            }
            return true;
        }

        public bool AddStudents(List<Student> roster)
        {
            SpaceCheck(roster.Count + studentRoster.Count);

            foreach (Student item in roster)
            {
                addStudent(item);
            }


            return true;
        }

        public Task<List<Student>> FetchRoster()
        {
            return Task.Run(() => { return studentRoster; });
        }

        public Student GetStudentById(int id)
        {

            var student = studentRoster.Where(x => x.Id == id).FirstOrDefault();
            return student;
        }

        public IEnumerable<Student> GetStudentByFirstName(string fn)
        {
            var student = studentRoster.Where(person => person.fname == fn && person.lname == "a");
            return student;
        }

        public Student GetStudentByWholeName(string name)
        {
            var result = studentRoster.Where(p => p.wholeName == name).FirstOrDefault();
            return result;
        }

        public Student GetStudentByWholeName(string firstname, string lastname)
        {
            return GetStudentByWholeName($"{firstname} {lastname}");

        }

        public List<Student> GetStudentRoster()
        {
            return studentRoster;
        }

        public bool removeStudentById(int id)
        {
           return studentRoster.Remove(GetStudentById(id));
        }

        public bool removeStudent(int id)
        {
            throw new NotImplementedException();
        }

        private bool SpaceCheck(int newCount)
        {
            if(newCount > Global.maxStudents)
            {
                throw new Exception(Errors.notEnoughSpace);
            }
            return true;
        }



        /// <summary>
        /// Normal Constructor
        /// </summary>
       /* public Course(string name, )
        {


        }
        
  */
    }
}
