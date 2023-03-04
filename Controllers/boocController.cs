using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using booc.Models;

namespace booc.Controllers;

public class boocController : Controller
{
    public IActionResult Index(){
        return View();

    }
    public IActionResult educ(){
        return View();

    }
    public IActionResult job(){
        return View();

    }
}
