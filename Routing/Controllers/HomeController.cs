using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Routing.Models;

namespace Routing.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Result", new Result {
                Controller = nameof(HomeController),
                Action = nameof(Index)
            });
        }

        public IActionResult CustomVariable(string id)
        {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(CustomVariable)
            };
            //r.Data["Id"] = RouteData.Values["id"];
            r.Data["Id"] = id;
            return View("Result", r);
        }
    }
}