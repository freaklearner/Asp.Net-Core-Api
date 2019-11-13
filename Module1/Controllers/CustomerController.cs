using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        static List<Customer> Customers = new List<Customer>()
        {
            new Customer(){ Id = 1, Name="Shub", Email="shub@gmail.com", Mobile="9900889908"},
            new Customer(){Id = 2, Name="Abhi",Email="abhi@gmail.com",Mobile="9988776655"}
        };

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return Customers;
        }
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            if (ModelState.IsValid)
            {
                Customers.Add(customer);
                return StatusCode(StatusCodes.Status201Created);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


    }
}