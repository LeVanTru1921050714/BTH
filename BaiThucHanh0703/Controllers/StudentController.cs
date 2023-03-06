using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;

namespace BaiThucHanh0703.Controllers;
public class StudentController:Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Sum()
    {
        return View();
    }
    public IActionResult PTB2()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName)
    {
        string strReturn = "Hello " + FullName;
        ViewBag.abc = strReturn; 
        return View();
    }
    [HttpPost]
     public IActionResult Sum(string sum)
    {
        int so = Convert.ToInt32(sum);
        int tong = 0;
        while(so > 0)
        {
            tong = tong + so%10;
            so = so/10;
        }
        ViewBag.xyz = "Tong cac chu so thanh phan cua " + sum + " = " + tong;
        return View();
    }
    [HttpPost]
        public IActionResult PTB2(double a, double b, double c)
    {
        double delta, x1, x2;
        string ketqua;
        if(a == 0) ketqua = "Day khong phai phuong trinh bac 2";
        else 
        {
            delta = Math.Pow(b,2) - 4*a*c;
        if(delta < 0) ketqua = "Phuong trinh vo nghiem";
        else if (delta == 0)
        {
        x1 = (-b)/(2*a);
        ketqua = "Phuong trinh co nghiem kep x = " + x1;
        }
        else
        {
            x1 = (-b + Math.Sqrt(delta))/(2*a);
            x2 = (-b - Math.Sqrt(delta))/(2*a);
            ketqua = "Phuong trinh co 2 nghiem phan biet x1 = " + x1 + ", x2 = " + x2;
        }
        }
        ViewBag.mess = ketqua;
        return View();
    }
    }