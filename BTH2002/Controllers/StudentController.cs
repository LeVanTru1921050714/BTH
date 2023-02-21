using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTH2002.Models;


namespace BTH2002.Controllers;
    public class StudentController : Controller
    {
       public IActionResult Index()
    {
        return View();
    }
       public IActionResult About()
    {
        return View();
    }
    }