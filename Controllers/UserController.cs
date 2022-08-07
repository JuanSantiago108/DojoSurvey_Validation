using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DJV_Done.Models;

public class UserController : Controller
{
    [HttpGet("/login")]
    public IActionResult Login()
    {
        return View("Login");
    }

    [HttpPost("user/create")]
    public IActionResult DashBoard(User newUser)
    {
        if (ModelState.IsValid)
        {
            return View("Dashboard", newUser);
        }
        else
        {
            return View("Login");
        }
    }



}