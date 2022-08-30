using Bookstore.Contracts;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Services
{
    public class StudentService : IStudentService
    {
        private readonly DBconnection _dbconnection;
        public StudentService()
        {
            _dbconnection = new DBconnection();
        }
       

        public bool AddStudent(Student stu)
        {
            return _dbconnection.AddStudent(stu);
        }

        

        public bool deleteStudent(int studentId)
        {
            return _dbconnection.deleteStudent(studentId);
        }

        public Student EditStudent(int studentId)
        {
            Student student=_dbconnection.Edit(studentId);
            return student;
        }

        public bool EditStudentDetails(Student student)
        {
            return _dbconnection.EditStudent(student);
        }

        public List<Student> GetStudents()
        {
            return _dbconnection.GetStudents();
        }
        
    }
}
