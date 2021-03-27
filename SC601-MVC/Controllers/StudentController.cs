using SC601_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SC601_MVC.Controllers
{
    public class StudentController : Controller
    {
        public IList<Student> students = new List<Student>() {
        new Student(){ IdStudent=1,StudentName="Angelina",Age=40 },
        new Student(){ IdStudent=2,StudentName="Jean Paul",Age=30 },
        new Student(){ IdStudent=3,StudentName="Ramon",Age=80 },
        new Student(){ IdStudent=4,StudentName="Kivian",Age=25 },
        new Student(){ IdStudent=5,StudentName="Kevin ",Age=30  }
        };

        public IList<Student> students1 = new List<Student>() {
        new Student(){ StudentName="Angelina"},
        new Student(){ StudentName="Jean Paul"},
        new Student(){ StudentName="Ramon"},
        new Student(){ StudentName="Kivian"},
        new Student(){ StudentName="Kevin "}
        };

        // GET: Student
        public ActionResult Index()
        {
            ViewBag.TotalStudents = students.Count();
            ViewBag.TotalStudents = 7;
            ViewBag.Test = "Esto es un TEst";

            ViewData["students"] = students1;
            return View();
        }
    }
}