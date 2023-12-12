namespace Pizzeria.Entities
{
    public class Pizza
    {
        public int Id { get; set; }  
        public string Descreption { get; set; }    
        public double Price { get; set; } 
        public bool Status { get; set;}
        
        public Pizza(int id,string des,double price,bool sta)
        {
            Id= id;
            Descreption= des;
            Price= price;
            Status = sta;
        }

    }
}
