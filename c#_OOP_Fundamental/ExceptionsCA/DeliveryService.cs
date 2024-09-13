namespace EceptionsCA
{
    public class DeliveryService {
        private readonly static Random random = new Random();
        public void Start(Delivery delivery)
        {
            try
            {

                Process(delivery);
                Transit(delivery);
                Shipping(delivery);
                Deliver(delivery);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"deliver fails due to : {ex.Message}");
                delivery.deleveryStatus = DeliveryStatus.UNKNOWN;

            }
        }
        public void Process(Delivery delivery) {
            if (random.Next(1, 5) == 1) {

                throw new InvalidOperationException("unable to process the item"); 
            }
            FAkeIt("Proccessing");
            delivery.deleveryStatus = DeliveryStatus.PROCCESSED;
           
        }
        public void Transit(Delivery delivery) {
            if (random.Next(1, 5) == 1)
            {

                throw new InvalidOperationException("فيه مشكلة يا حلوفة ");
            }
            delivery.deleveryStatus = DeliveryStatus.INTANSIT;

        }
        public void Shipping(Delivery delivery) {
            FAkeIt("Shapping");

            delivery.deleveryStatus = DeliveryStatus.SHIPPING;

        }
        public void Deliver(Delivery delivery) {
            FAkeIt("Deleviring");
            delivery.deleveryStatus = DeliveryStatus.DELIVERT;  
        }

        private void FAkeIt(string title) { 
          Console.Write(title);
            System.Threading.Thread.Sleep(300);  // Delay 300
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.Write(".");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine(".");
        }
    }
    }
