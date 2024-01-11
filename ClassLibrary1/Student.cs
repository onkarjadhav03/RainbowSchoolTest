using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Enroll(string subject)
        {
            // Logic for enrollment
            return true;
        }

        public string GetGrade(string subject)
        {
            // Logic to get grade for a subject
            return "A";
        }
    }
}
