using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Contracts
{
    public interface IStudentService
    {
        bool AddStudent(Student stu);
        List<Student> GetStudents();
        bool deleteStudent(int studentId);
        Student EditStudent(int studentId);

        bool EditStudentDetails(Student student);

    }
}
