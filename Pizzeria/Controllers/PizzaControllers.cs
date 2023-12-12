using Microsoft.AspNetCore.Mvc;
using Pizzeria.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizzeria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        static List<Pizza> pizzas = new List<Pizza> { new Pizza(1,"our first pizza",45,true) };
        static int counter = 2;
        // GET: Pizzeria/<PizzaController>
        [HttpGet]
        public ActionResult <List<Pizza>> Get()
        {
            return pizzas;
        }

        // GET Pizzeria/<PizzaController>/5
        [HttpGet("{id}")]
        public ActionResult <Pizza> Get(int id)
        {
            if ((id > counter) || (id < 1))
                return NotFound();
            return pizzas.Find(c => c.Id == id);
        }

        // POST Pizzeria/<PizzaController>
        [HttpPost]
        public void Post([FromBody] Pizza e)
        {
            pizzas.Add(new Pizza ( e.Id, e.Descreption.ToString(),e.Price,e.Status ));
            counter++;

        }

        // PUT Pizzeria/<PizzaController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Pizza p)
        {
            Pizza p1 = pizzas.Find(x => x.Id == id);
            if(p1 == null)
            {
                p1.Descreption=p.Descreption.ToString();    
                p1.Price=p.Price;    
                p1.Id=id;
                p1.Status = p.Status;
                return Ok();
            }
            else
                return NotFound();
        }

    }
}

