using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ToDoList;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}
