using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateTimeNowTestingExample.Classes;
using Microsoft.AspNetCore.Mvc;

namespace DateTimeNowTestingExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = GetDateAwareGreeting();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public string GetDateAwareGreeting()
        {
            var today = TestableDateTime.GetDateTimeNow().DayOfWeek;

            switch (today)
            {
                case DayOfWeek.Monday:
                    return "It's the start of a new week!";
                case DayOfWeek.Tuesday:
                    return "Almost halfway there!";
                case DayOfWeek.Wednesday:
                    return "Happy Humpday!";
                case DayOfWeek.Thursday:
                    return "Almost Friday!";
                case DayOfWeek.Friday:
                    return "TGIF!";
                case DayOfWeek.Saturday:
                    return "It's Saturday!";
                case DayOfWeek.Sunday:
                    return "Let's get ready for a new week!";
                default:
                    return "Greetings!";
            }

           
        }
    }
}
