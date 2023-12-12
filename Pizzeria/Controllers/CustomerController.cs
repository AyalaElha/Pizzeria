using Microsoft.AspNetCore.Mvc;
using Pizzeria.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizzeria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _context;
        public CustomerController(DataContext context)
        {
            _context = context;
        }
        
        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult <List<Customer>>Get()
        {
            return _context.Customers;
        }

        // GET Pizzeria/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult <Customer> Get(int id)
        {
            if((id > _context.CounterC) || (id < 1))
                 return StatusCode(404, "Customer not found");
            return _context.Customers.Find(c => c.Id == id);
        }

        // POST Pizzeria/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer c)
        {
            _context.Customers.Add(new Customer(_context.CounterC, c.Name,c.Phone,c.Adress));
            _context.CounterC++;//בדיקה
        }

        // PUT Pizzeria/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer c)
        {
            Customer c1 = _context.Customers.Find(x=> x.Id == id);
            if (c1 != null)
            {
                c1.Name = c.Name;
                c1.Phone = c.Phone;
                c1.Adress = c.Adress;
                return Ok();
            }
            return  NotFound();
        }
    }
}



