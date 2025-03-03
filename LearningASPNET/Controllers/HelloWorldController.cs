using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;



namespace LearningASPNET.Controllers;

public class HelloWorldController : Controller
{
   public string Index()
    {
        return "This is my default action....";
    }

    public string Welcome(string Name, int Age)
    {
        return HtmlEncoder.Default.Encode($"Hello {Name}, your age is {Age}");
    }
}

