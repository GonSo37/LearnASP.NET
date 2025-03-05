using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;



namespace LearningASPNET.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public string Welcome(string Name, int Age)
    {
        return HtmlEncoder.Default.Encode($"Hello {Name}, your age is {Age}");
    }
}

