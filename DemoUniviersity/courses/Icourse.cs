using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity.Users;

namespace DemoUniviersity.courses
{
    interface Icourse
    {
        int rosterCount { get; }
        bool addStudent(Student student);
        bool AddStudents(List<Student> roster); 
        bool removeStudent(int id);
        bool removeStudentById(int id);
        //bool removeStudent(string fname, string lname);


        


        bool isFull { get; }
    }
        
}
