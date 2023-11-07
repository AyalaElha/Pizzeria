using Microsoft.AspNetCore.Mvc;
using Pizzeria.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizzeria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        static List<Order> orders = new List<Order> { new Order ( 1,  1,new List<Pizza> { new Pizza(1, "null", 45) },DateTime.Today ) };
        static int counter = 2;
        // GET: api/<EventsController>
        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            return orders;
        }

        // GET Pizzeria/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            if ((id > counter) || (id < 1))
                return StatusCode(404, "Order not found");
            return orders.Find(c => c.Id == id);
        }

        // POST Pizzeria/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Order o)
        {
            orders.Add(new Order(counter, o.Id,o.Pizzalst,o.OrderDate));
            counter++;
        }

        // PUT Pizzeria/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order o)
        {
            Order o1 = orders.Find(x => x.Id == id);
            if (o1 != null)
            {
                o1.Pizzalst = o.Pizzalst;
                o1.IdCustomer = o.IdCustomer;
                o1.OrderDate = o.OrderDate;        
            }
            //todo:?
        }
    }
}



