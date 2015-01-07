using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryApp
{
   public class Department
    {
       public string Code { set; get; }
       public string Name { set; get; }
       private List<Student> students;
       private const int MAX_NO_OF_STUDENT = 10;
       public Department(string code, string name) :this()
       {
           Name = name;
           Code = code;
          
       }
       public Department()
       {
           students = new List<Student>();
       }

       public string AddStudent(Student aStudent)
       {
           if (students.Count < MAX_NO_OF_STUDENT)
           {
               if(hasthisrenNO(aStudent.RegNo))
               {
                   return "Already Exits";
               }
               students.Add(aStudent);
               return "Student Added";
           }
           else
           {
               return "OverFlow";
           }
       }

       private bool hasthisrenNO(string regNo)
       {
           foreach (Student studentRef in students)
           {
               if (studentRef.RegNo== regNo )
               {
                   return true;
               }
           }
           return false;
       }


       public  Student[] GetStudent()
       {
           return students.ToArray();
       }

       
    }
}
