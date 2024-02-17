using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetStudents.Models;

namespace GetStudents.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Students()
        {
            ViewBag.Message = "STUDENT LIST";

            Students student1 = new Students(3542, "Eymen Karabudak", "BackEnd");
            Students student2 = new Students(1054, "Fehmi Yaşar", "BackEnd");
            Students student3 = new Students(52185, "Elif Ukteli", "FrontEnd");
            Students student4 = new Students(18248, "Yusuf Ökten", "BackEnd");
            Students student5 = new Students(4525, "Emre Korkmaz", "Game Development");
            Students student6 = new Students(47922, "Vildan Temel", "BackEnd");
            Students student7 = new Students(1858, "Dilara Aktaş", "Game Development");
            Students student8 = new Students(1568, "Sena Durmus", "FrontEnd");

            var studentList = new List<Students>();
            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);
            studentList.Add(student5);
            studentList.Add(student6);
            studentList.Add(student7);
            studentList.Add(student8);

            return View(studentList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
