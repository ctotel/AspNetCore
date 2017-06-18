using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Ticket")]
    public class TicketController : Controller
    {
        // Simnple example to return string
        // [HttpGet("/")]  Take over every thing 
        // Would now be tix
        //  [HttpGet("/tix")]
        // public string Index() => "Hello from tickets";
        // Back to default

        [HttpGet("/tix")]
        public IActionResult Index()
        {
            // Get to the database
            var s = new Seat() { Location = "Orchestra", Price = 300.0 };
    
            return View(s);
        }
    }
}