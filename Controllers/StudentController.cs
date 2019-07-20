using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class StudentController : Controller
    {
        StudentContext db = new StudentContext();
        // GET: Student
        public ActionResult List()
        {
            IEnumerable<Student> students = db.Students;
            ViewBag.Students = students;
            return View();
        }

        [HttpGet]
        public ActionResult View(int id)
        {
            Student student = db.Students.Find(id);
            return View(student);
        }
    }
}