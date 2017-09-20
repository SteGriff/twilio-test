using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TwilioTest.Web.Controllers
{
    public class XmlController : Controller
    {
        public override ViewResult View()
        {
            Response.ContentType = "application/xml";
            return base.View();
        }
    }
}
