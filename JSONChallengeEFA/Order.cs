using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallengeEFA
{
    public class Order
    {
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public List<LineItems> LineItems { get; set; }
        public DateTime PurschaseDate { get; set; }

        public Order() { }

        public Order(int orderId, Customer customer, List<LineItems> lineItems, DateTime purschaseDate)
        {
            OrderID = orderId;
            Customer = customer;
            LineItems = lineItems;
            PurschaseDate = purschaseDate;
        }
    }
}
