using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Routing.Models;

namespace Routing.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View("Result", new Result {
                Controller = nameof(CustomerController),
                Action = nameof(Index)
            });
        }

        public IActionResult List(string id)
        {
            Result r = new Result
            {
                Controller = nameof(CustomerController),
                Action = nameof(List)
            };
            r.Data["Id"] = id ?? "<no data>";
            r.Data["CatchAll"] = RouteData.Values["catchall"];
            return View("Result", r);
        }
    }
}