using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity.Users;
using DemoUniviersity.Courses;



namespace DemoRegApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Student> slist = new List<Student>();
            Course testCourse = new Course("Course101", new DateTime());
            Student s = new Student("f", "l", "pwd", "a@a.com", 1);
            
            Student paul = new Student("Paul", "a", "pwd", "1@1.com", 1);
            Student mike = new Student("Mike", "a", "pwd", "2@2.com", 2);
            Student stephen = new Student("Stephen", "a", "pwd", "3@3.com", 3);
            Student chris = new Student("Chris", "a", "pwd", "4@4.com", 4);
            Student devonte = new Student("Devonte", "a", "pwd", "5@5.com", 5);
            Student alain = new Student("Alain", "a", "pwd", "6@6.com", 6);
            Student antone = new Student("Antone", "a", "pwd", "7@7.com", 7);
            Student erik = new Student("Erik", "a", "pwd", "8@8.com", 8);
            Student summer = new Student("Summer", "a", "pwd", "9@9.com", 9);
            Student kirk = new Student("Stephen", "b", "pwd", "10@10.com", 10);
            Course dotnet = new Course("dotnet", new DateTime());

           
          

            


            dotnet.addStudent(paul);
            dotnet.addStudent(mike);
            dotnet.addStudent(stephen);
            dotnet.addStudent(chris);
            dotnet.addStudent(devonte);
            dotnet.addStudent(alain);
            dotnet.addStudent(antone);
            dotnet.addStudent(erik);
            dotnet.addStudent(summer);
            dotnet.addStudent(kirk);
            dotnet.addStudent(paul);
            dotnet.addStudent(mike);
            dotnet.addStudent(stephen);
            dotnet.addStudent(chris);
            dotnet.addStudent(devonte);
            dotnet.addStudent(alain);
            dotnet.addStudent(antone);
            dotnet.addStudent(erik);
            dotnet.addStudent(summer);
            dotnet.addStudent(kirk);

            var studentlist = dotnet.GetStudentRoster();
            Console.ReadLine();
           
            /*
            Console.WriteLine(testCourse.rosterCount);
            testCourse.addStudent(s);
            Console.WriteLine(testCourse.rosterCount);


            try
            {
                testCourse.AddStudents(slist);
            }
             
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.ToString());
            }   

            for (int i = 0; i < 21; i++)
            {
                slist.Add(s);
            }
            Console.WriteLine(testCourse.rosterCount);

            try
            {
                testCourse.AddStudents(slist);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
            */
        }
    }
}
