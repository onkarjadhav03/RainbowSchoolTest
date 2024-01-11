using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private readonly IStudent _student;

        public Subject(string name, IStudent student)
        {
            Name = name;
            _student = student;
        }

        public string GetGrade()
        {
            // Logic to get grade using the student object
            return _student.GetGrade(Name);
        }
    }
}
