using Microsoft.AspNetCore.Mvc;
using Pizzeria.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizzeria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly DataContext _context;
        public PizzaController(DataContext context)
        {
                _context=context;
        }
        // GET: Pizzeria/<PizzaController>
        [HttpGet]
        public ActionResult <List<Pizza>> Get()
        {
            return _context.Pizzas;
        }

        // GET Pizzeria/<PizzaController>/5
        [HttpGet("{id}")]
        public ActionResult <Pizza> Get(int id)
        {
            if ((id > _context.CounterP) || (id < 1))
                return NotFound();
            return _context.Pizzas.Find(c => c.Id == id);
        }

        // POST Pizzeria/<PizzaController>
        [HttpPost]
        public void Post([FromBody] Pizza e)
        {
            _context.Pizzas.Add(new Pizza ( e.Id, e.Descreption.ToString(),e.Price,e.Status ));
            _context.CounterP++;

        }

        // PUT Pizzeria/<PizzaController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Pizza p)
        {
            Pizza p1 = _context.Pizzas.Find(x => x.Id == id);
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

