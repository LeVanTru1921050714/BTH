using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BTH1303.Models;

namespace BTH1303.Controllers;

public class PTB2Controller : Controller
{
    PTB2 gpt = new PTB2();
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string hesoA, string hesoB, string hesoC)
    {
        string ketqua = "";
        double a = 0, b, c;
        if(!string.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
        if(!string.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
        if(!string.IsNullOrEmpty(hesoC)) c = Convert.ToDouble(hesoC);
        if(a == 0) ketqua = "Day khong phai phuong trinh bac 2";
        else
        {
            ketqua = gpt.Giaiphuongtrinh(hesoA,hesoB,hesoC);           
        }
        ViewBag.mess = ketqua;
        return View();
    }
}