using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabas
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? City { get; set; } = string.Empty;

        public Student(string? firstName, string? lastName, string? city) 
        {
            FirstName =  firstName; 
            LastName = lastName; 
            City = city;

        }
    }
}
