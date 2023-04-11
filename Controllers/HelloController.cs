using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebsite.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        //static responses
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>"

            + "<label> Name: <input type = 'text' name = 'name'/> </label>"
            + "<input type ='submit' value = 'Greet Me!' />"
            + "</form>";
            return Content(html, "text/html");
        }

        //query parameters
        // Get: /hello/welcome
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(String name = "World")
        {
            return Content("<h1> Welcome To My App, " + name + "!<h1>", "text/html");
        }

    }
}