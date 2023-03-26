using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTH2003.Models;

namespace BTH2003.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create()
        {
        return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            string kq = std.StudentCode + "-" + std.FullName + "-" + std.Address;
            ViewBag.render = kq;
            return View();
        }
    }
}