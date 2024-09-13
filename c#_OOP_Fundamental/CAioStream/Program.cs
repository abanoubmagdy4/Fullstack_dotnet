using System;
using System.Collections.Generic;
using System.Net.Http;
namespace CAioStream
{
    class Program
    {
        static void Main(string[] args)
        {

            using (CurrencyService currencyService = new CurrencyService() ) {
                var result = currencyService.GetCurrencies();
                Console.WriteLine(result);
            };
                Console.ReadKey();
              

        }//End Of Main

    }// End Of Class Program
    class CurrencyService : IDisposable{
        private readonly HttpClient httpClient;
         private  bool _Disposed = false;
      public CurrencyService()

        { 
             httpClient = new HttpClient();
        }

        public string GetCurrencies() {
            string url = "https://coinbase.com/api/v2/currencies";
             var result = httpClient.GetStringAsync(url).Result;
            return result;
        }

        ~CurrencyService() { 
        
            Dispose(false);
        
        }
        // Dispose Managed + UnManaged == disposing = true
        // Dispose Unmanagded + large fields  disposing ==false
        protected virtual void Dispose(bool disposing) {
            if (_Disposed) // return  if _disposed == true  عشان مينفذش الميثود اساساً
                return;

            if (disposing)
            {
                //dispose managed resources
                httpClient.Dispose(); //هنا هيروح ينفذ دي اللي موجوده في الكلاس الخاصة بعملية التنظيف
            }
             
            _Disposed = true; // برجع القيمة لترو علشان ينفذ الكود مره واحده بس وينظف مره واحده بس
                    
        }

        public void Dispose() { 
        
            Dispose(true);  
            GC.SuppressFinalize(this); /// دي معناها طلاما جيت لحد هنا يبقى انت نفذت الكود ومتبعش كلام الفاينلايزر البايظ مش هنضف اللي اتنضف احنا
        }
    
    }

}// End Of Namespace
