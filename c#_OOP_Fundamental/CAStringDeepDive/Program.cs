using System;
using System.Net.Http;
using System.Text;
namespace CAStringDeepDive
{
     class Program {
        static void Main(string[] args) {
            //Example of extracting data from a website and storing it in a file on the device
            Task.Run(() => GetDataAsciiFormat());
            Console.ReadKey();
         
        }

        static async Task GetDataAsciiFormat() {
            var path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            var filepath = $"{path}\\folder\\asciiNewsContent.txt";
            using (var client = new HttpClient()) {
                Uri uri = new Uri("https://aljazeera.net/search/feed");
                using (HttpResponseMessage response =  await  client.GetAsync(uri))
                {
                    var byteArray = await response.Content.ReadAsByteArrayAsync();
                    string result  = Encoding.ASCII.GetString(byteArray);
                    File.WriteAllText(filepath,result);
                }


            }


            Console.WriteLine("completed");

        }
        }
    }
