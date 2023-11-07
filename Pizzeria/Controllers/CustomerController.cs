using Microsoft.AspNetCore.Mvc;
using Pizzeria.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizzeria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        static List<Customer> customers = new List<Customer> {new Customer(1,"Ayala","0556768676","havakuk 1- bnei brak") };
        static int counter = 2;
        // GET: api/<EventsController>
        [HttpGet]
        public ActionResult <List<Customer>>Get()
        {
            return customers;
        }

        // GET Pizzeria/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult <Customer> Get(int id)
        {
            if((id > counter) || (id < 1))
                 return StatusCode(404, "Customer not found");
            return customers.Find(c => c.Id == id);
        }

        // POST Pizzeria/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer c)
        {
            customers.Add(new Customer(counter,c.Name,c.Phone,c.Adress));
            counter++;
        }

        // PUT Pizzeria/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer c)
        {
            Customer c1 = customers.Find(x=> x.Id == id);
            if (c1 != null)
            {
                c1.Name = c.Name;
                c1.Phone = c.Phone;
                c1.Adress = c.Adress;
            }
            //todo:?
        }
    }
}



