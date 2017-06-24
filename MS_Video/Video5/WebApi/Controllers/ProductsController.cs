using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        private static List<Product> _p = new List<Product>(new[]{

            new Product() { ID = 1, Name = "Green Test"},
            new Product() { ID = 2, Name = "Soft Taco"},

            });


        [HttpGet]
        public List<Product> Get()
        {
            return _p;
        }
        /*
                // Get a single one with ID
                [HttpGet("{id}")]   // capture routine parameter 
                public Product Get(int id)
                {
                    return _p.SingleOrDefault(_p => _p.ID == id);
                }
                */
        // Get a single one with ID
        [HttpGet("{id}")]   // capture routine parameter 
        public IActionResult Get(int id)
        {
            var prod = _p.SingleOrDefault(_p => _p.ID == id);

            if (prod == null)
            {
                return NotFound();
            }

            return Ok(prod);
        }



    }
}