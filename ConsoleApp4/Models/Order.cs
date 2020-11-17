using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public List<string> Articles { get; set; }

        public Order()
        {
            Articles = new List<string>();
        }

        public void Finish()
        {
            DeliveryDate = DateTime.UtcNow;
        }
    }
}
