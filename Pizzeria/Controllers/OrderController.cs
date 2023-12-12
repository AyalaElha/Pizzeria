using Microsoft.AspNetCore.Mvc;
using Pizzeria.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizzeria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DataContext _context;
        public OrderController(DataContext context)
        {
          _context = context;
        }

        // GET: api/<EventsController>
        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            return _context.Orders;
        }

        // GET Pizzeria/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            if ((id > _context.CounterO) || (id < 1))
                return StatusCode(404, "Order not found");
            return _context.Orders.Find(c => c.Id == id);
        }

        // POST Pizzeria/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Order o)
        {
            _context.Orders.Add(new Order(_context.CounterO,o.IdCustomer,o.Pizzalst,o.OrderDate));
            _context.CounterO++;
        }

        // PUT Pizzeria/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Order o)
        {
            Order o1 = _context.Orders.Find(x => x.Id == id);
            if (o1 != null)
            {
                o1.Pizzalst = o.Pizzalst;
                o1.IdCustomer = o.IdCustomer;
                o1.OrderDate = o.OrderDate;
                return Ok();
            }
           return NotFound();
        }
    }
}



