using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Options;

namespace OptionsBindSample.Controllers
{
    public class HomeController : Controller
    {
        // private readonly Class _myClass;

        // public HomeController(IOptions<Class> classAccesser)
        // {
        //     _myClass = classAccesser.Value;
        // }
        // public ActionResult Index()
        // {
        //     return View(_myClass);
        // }

        public ActionResult Index()
        {
            return View();
        }
    }
}