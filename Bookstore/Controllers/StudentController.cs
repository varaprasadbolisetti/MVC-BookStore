using Bookstore.Contracts;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService StudentService;
        public StudentController(IStudentService studentService)
        {
            StudentService = studentService;
        }
        public IActionResult GetStudents()
        {
            var students = StudentService.GetStudents();
            return View("AddStudent", students);

        }
        [HttpPost]
        public JsonResult deleteStudent(int studentId)
        {
            return Json(StudentService.deleteStudent(studentId));
        }
        [HttpPost]
        public JsonResult AddStudent([FromBody] Student stu)
        {
            return Json(StudentService.AddStudent(stu));
        }
        public IActionResult Edit(int id)
        {
            Student student=StudentService.EditStudent(id);
            return View(student);
        }

        [HttpPost]
        public JsonResult EditStudentDetails([FromBody] Student stud)
        {
            return Json(StudentService.EditStudentDetails(stud));
        }

    }


}


