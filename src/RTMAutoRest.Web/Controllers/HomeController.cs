using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RTMAutoRest.Web.ViewModels;
using RTMAutoRest.Clients;

namespace RTMAutoRest.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeViewModel();

            return View(model);
        }
    }
}