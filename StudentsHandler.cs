using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabas
{
    internal class StudentsHandler
    {
        private MyDbContext thisDbContext;
        public StudentsHandler(MyDbContext thisdbcontext)
        {
            thisDbContext = thisdbcontext;
        }

        public void AddStudent(string? firstname, string? lastname, string? city)
        {
            var student = new Student(firstname, lastname, city);
            thisDbContext.Students.Add(student);
            thisDbContext.SaveChanges();
        }

        public void ListStudents()
        {
            foreach (var student in thisDbContext.Students)
            {
                Console.WriteLine($"ID: {student.StudentId}    Namn: {student.FirstName} {student.LastName}   Stad: {student.City}");
            }
        }

        public void ChangeStudentFirstName(int studentid, string? firstname) 
        {
            
            var thisStudent = thisDbContext.Students.First(s=>s.StudentId== studentid);
            
            thisStudent.FirstName = firstname;
            thisDbContext.SaveChanges();

        }
        public void ChangeStudentLastName(int studentid, string? lastname)
        {
            var thisStudent = thisDbContext.Students.First(s => s.StudentId == studentid);
            
            thisStudent.LastName = lastname;
            thisDbContext.SaveChanges();

        }
        public void ChangeStudentCity(int studentid, string? city)
        {
            var thisStudent = thisDbContext.Students.First(s => s.StudentId == studentid);
            
            thisStudent.City = city;
            thisDbContext.SaveChanges();
        }

        public void RemoveStudent(int studentid) 
        {
            var thisStudent = thisDbContext.Students.First(s => s.StudentId == studentid);
          
            thisDbContext.Students.Remove(thisStudent);
            thisDbContext.SaveChanges();

        }
    }
}
