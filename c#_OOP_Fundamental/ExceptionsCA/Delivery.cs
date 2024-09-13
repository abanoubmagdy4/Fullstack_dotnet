namespace EceptionsCA
{
    public class Delivery {

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public DeliveryStatus deleveryStatus { get; set; }

        public override string ToString()
        {
            return  $"{{ \n{Id}   \n{CustomerName}  \n{Address} \n{deleveryStatus } \n}}";
        }

    }
     

    
    }
