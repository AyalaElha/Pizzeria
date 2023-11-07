namespace Pizzeria.Entities
{
    public class Order
    {
        public int Id { get; set; } 
        public int  IdCustomer { get; set; }
        public List<Pizza> Pizzalst { get; set; } = new List<Pizza>();
        public DateTime OrderDate { get; set; }
        public Order(int id,int idCustomer, List<Pizza> Pizzalst,DateTime orderDate)
        {
            Id = id;    
            IdCustomer = idCustomer;    
            this.Pizzalst=Pizzalst; 
            this.OrderDate = orderDate; 
        }

    }
}
