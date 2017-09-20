using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TwilioTest.Web.Controllers
{
    public class CallController : XmlController
    {
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetAccessCode()
        {
            return View();
        }
    }
}