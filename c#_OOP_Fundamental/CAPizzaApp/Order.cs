using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPizza
{
    internal class Order
    {
        protected int orderID { get; set; }
        protected string orderName { get; set; }
        

        Order(int orderid, string oredername) {

            this.orderID = orderid;
            this.orderName = oredername;
        }

        public string PlaceOrder(string place) {
            Console.WriteLine("Inter Your Place");
            place = place.ToLower();    
            return place;
        }
        public void RreserveOrder() { 
            var reserve = 
        
        }

    }
}
