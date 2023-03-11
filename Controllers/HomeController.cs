using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using booc.Models;
using routing_act_main.Models;

namespace booc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
         ViewData["age"] = 21;
         Person p = new Person(){
                id =3,
                fullname= "clientstewart",
                age = 21
         };
         Person p1 = new Person(){
                id =33,
                fullname= "clientstewart",
                age = 24
         };
         Person p2 = new Person(){
                id =32,
                fullname= "clientstewart",
                age = 23
         };
         Person p3 = new Person(){
                id =31,
                fullname= "clientstewart",
                age = 22
         };
         List<Person> Listp = new List<Person>();
         Listp.Add(p);
         Listp.Add(p1);
         Listp.Add(p2);
         Listp.Add(p3);

        return View(Listp);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
