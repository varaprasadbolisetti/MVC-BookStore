using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public char StudentGender { get; set; }
        public string StudentCourse { get; set; }
        public DateTime StudentJoindate { get; set; }

    }
    public class StudentList
    {
        public List<Student> students { get; set; }
        public Student student { get; set; }
    }
}
