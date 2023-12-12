using Pizzeria.Entities;
namespace Pizzeria
{
    public class DataContext
    {
        public List<Pizza> Pizzas { get; set; }
        public int CounterP { get; set; }
        public List<Order> Orders { get; set; }
        public int CounterO { get; set; }
        public List<Customer> Customers { get; set; }
        public int CounterC { get; set; }
        public DataContext()
        {
            Pizzas = new List<Pizza>(); //{ new Pizza(counterP++, "our first pizza", 45,true) };
            Orders = new List<Order>(); //{ new Order(counterO++, 1, new List<Pizza> { new Pizza(1, "null", 45) }, DateTime.Today) };
            Customers = new List<Customer>(); //{ new Customer(counterC++, "Ayala", "0556768676", "havakuk 1- bnei brak") };
            CounterO = 1;
            CounterC = 1;
            CounterP = 1;
            //עכול להיות שעדיף שהמוני םיהיה קבועים למעלה ומאותחלים ל1
        }
    }
}
