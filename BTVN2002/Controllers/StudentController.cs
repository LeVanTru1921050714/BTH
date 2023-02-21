using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTVN2002.Models;

 namespace BTVN2002.Controllers;
    public class StudentController:Controller
    {
       public IActionResult Index()
    {
        return View();
    }
    }