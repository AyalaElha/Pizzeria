namespace Pizzeria.Entities
{
    public class Customer
    {
        private int v1;
        private string v2;
        private object p;

        public int Id { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }
        public string Adress { get; set; }

        

        public Customer(int id, string name, string phone,string adress)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Adress = adress;
        }
    }
}
