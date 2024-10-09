using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SampleSecureWeb.Models;

namespace SampleSecureWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //ViewData["Username"] = "Yuanita Puspitasari";
        ViewBag.username = "Yuanita Puspitasari";
        string[] fruits = new string[] {"Apple", "Banana", "Orange"};
        ViewBag.fruits = fruits;
        return View();
    }

    public IActionResult About()
    {
        ViewData["Title"] = "About Page";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
