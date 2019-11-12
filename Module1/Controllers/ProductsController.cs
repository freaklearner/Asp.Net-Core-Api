using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        ProductDbContext context;
        static List<Products> _products = new List<Products>()
        {
            new Products(){Id = 1, Name = "P1", Price = 20},
            new Products(){Id = 2, Name = "P2", Price = 30}
        };

        public ProductsController(ProductDbContext productDbContext)
        {
            context = productDbContext;

        }

        
        public IActionResult Get()
        {
            return StatusCode(StatusCodes.Status200OK, context.Products.ToList());
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int id)
        {
            //return StatusCode(StatusCodes.Status200OK, _products[0]);
            var product = context.Products.SingleOrDefault(x => x.Id == id);
            if (product != null)
            {
                return StatusCode(StatusCodes.Status200OK, product);
            }
            else
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }
        }

        [HttpGet("GetSecondProduct")]
        public IActionResult GetSecondProduct()
        {
            return StatusCode(StatusCodes.Status200OK, _products[1]);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Products products)
        {
            context.Products.Add(products);
            try
            {
                context.SaveChanges(true);
                return StatusCode(StatusCodes.Status201Created,"Data Added Successfully");

            }catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
            //_products.Add(products);
            //return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPost("FirstElement")]
        public IActionResult PostFirstElement([FromBody]Products products)
        {
            _products.Insert(0,products);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPost("SecondElement")]
        public IActionResult PostSecondElement([FromBody]Products products)
        {
            _products.Insert(1, products);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{Id}")]
        public void Put(int Id,[FromBody] Products products)
        {
            _products[Id] = products;
        }

        [HttpDelete("{Id}")]
        public void Delete(int Id)
        {
            _products.RemoveAt(Id);
        }

    }
}